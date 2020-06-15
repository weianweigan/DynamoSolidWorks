using Autofac;
using Du.SolidWorks;
using Du.SolidWorks.Attributes;
using Du.SolidWorks.Extension;
using Du.SolidWorks.Interface;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidWorksTools.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Du.SwAddinBase.Service
{
    public class SWCMDGroupService : ISWCMDGroupService
    {
        #region services

        private readonly ISolidWorksAddin _addin;
        private readonly BitmapHandler iBmp;
        private readonly ICommandManager iCmdMgr;
        private readonly IStartup _startup;
        private readonly ISWAddinCommand _addinCommand;

        #endregion

        #region private variable

        private bool getDataResult;
        private bool ignorePrevious;

        private swDocumentTypes_e[] docTypes = new swDocumentTypes_e[]{swDocumentTypes_e.swDocASSEMBLY,
                                       swDocumentTypes_e.swDocDRAWING,
                                       swDocumentTypes_e.swDocPART};

        #endregion

        #region .ctor

        public SWCMDGroupService(ISolidWorksAddin addin, ISWAddinCommand addinCommand, ICommandManager iCmdMgr, IStartup startup)
        {
            _addin = addin;
            this.iCmdMgr = iCmdMgr;
            _startup = startup;
            _addinCommand = addinCommand;

            if (_addinCommand.CommandInstances == null) { _addinCommand.CommandInstances = new Dictionary<string, object>(); }
            if (_addinCommand.CmdGroupIDs == null) { _addinCommand.CmdGroupIDs = new List<int>(); }

            iBmp = new BitmapHandler();
        }

        #endregion

        #region methods

        #region public method

        public ICommandGroup AddCommandGroup(GroupData groupData, ILifetimeScope scope)
        {
            ICommandGroup cmdGroup;

            int mainCmdGroupID = 0;

            int cmdGroupErr = 0;

            object registryIDs;

            _addinCommand.CmdGroupIDs.Add(mainCmdGroupID);

            var config = groupData.TabStyles.Select(p =>
    p.GetProperties().Select(q =>
          new KeyValuePair<int, Type[]>(q.GetCustomAttribute<BoxOrderAttribute>()?.Order ?? 1,
          q.GetCustomAttribute<CommandCollectionAttribute>()?.Commands)).
          OrderBy(r => r.Key));

            //计算按钮数量
            int cmdCount = 0;
            foreach (var doc in config)
            {
                foreach (var properties in doc)
                {
                    cmdCount = cmdCount + properties.Value.Length;
                }
            }
            //thisAssembly = System.Reflection.Assembly.GetAssembly(this.GetType());

            //get the ID information stored in the registry
            getDataResult = iCmdMgr.GetGroupDataFromRegistry(mainCmdGroupID, out registryIDs);

            //_addinCommand.CommandInstances = new Dictionary<string, object>();

            int[] knownIDs = new int[cmdCount];
            for (int i = 0; i < knownIDs.Length; i++)
            {
                knownIDs[i] = i;
            }

            if (getDataResult)
            {
                if (!CompareIDs((int[])registryIDs, knownIDs)) //if the IDs don't match, reset the commandGroup
                {
                    ignorePrevious = true;
                }
            }
            ignorePrevious = true;

            cmdGroup = iCmdMgr.CreateCommandGroup2(mainCmdGroupID, groupData.Title, groupData.ToolTip, groupData.Hint, -1, ignorePrevious, ref cmdGroupErr);
            cmdGroup.LargeIconList = iBmp.CreateFileFromResourceBitmap(groupData.Icons[0], groupData.IconAssembly);
            cmdGroup.SmallIconList = iBmp.CreateFileFromResourceBitmap(groupData.Icons[1], groupData.IconAssembly);
            cmdGroup.LargeMainIcon = iBmp.CreateFileFromResourceBitmap(groupData.Icons[2], groupData.IconAssembly);
            cmdGroup.SmallMainIcon = iBmp.CreateFileFromResourceBitmap(groupData.Icons[3], groupData.IconAssembly);

            //添加按钮
            int CommandIndex = 0;
            int j = 0;
            List<Dictionary<int, KeyValuePair<CommandType, int>>>[] tabIds = new List<Dictionary<int, KeyValuePair<CommandType, int>>>[3];

            foreach (var docConfig in config)//文档
            {
                tabIds[j] = new List<Dictionary<int, KeyValuePair<CommandType, int>>>();
                foreach (var properties in docConfig)//属性
                {
                    Dictionary<int, KeyValuePair<CommandType, int>> boxIds = new Dictionary<int, KeyValuePair<CommandType, int>>();
                    foreach (var item in properties.Value)//Commands
                    {
                        var keyvalue = AddCommnad(scope, item, ref cmdGroup, CommandIndex);
                        boxIds.Add(keyvalue.Key, keyvalue.Value);
                        CommandIndex++;
                    }
                    if (boxIds.Count > 0)
                    {
                        tabIds[j].Add(boxIds);
                    }
                }
                j++;
            }

            cmdGroup.HasToolbar = true;
            cmdGroup.HasMenu = true;
            cmdGroup.Activate();
            //cmdGroup.sho

            //排列按钮
            foreach (var type in docTypes)
            {
                //此种文档类型无按钮,则跳出
                int arrayIndex = 0;
                switch (type)
                {
                    case swDocumentTypes_e.swDocPART:
                        arrayIndex = 0;
                        break;
                    case swDocumentTypes_e.swDocASSEMBLY:
                        arrayIndex = 1;
                        break;
                    case swDocumentTypes_e.swDocDRAWING:
                        arrayIndex = 2;
                        break;
                    default:
                        throw new InvalidOperationException($"Can not add CommandTabBox with {type.ToString()}");
                }
                if (tabIds[arrayIndex].Count < 1)
                {
                    break;
                }

                CommandTab cmdTab;

                cmdTab = iCmdMgr.GetCommandTab(type.SWToInt(), groupData.Title);

                if (cmdTab != null & !getDataResult | ignorePrevious)//if tab exists, but we have ignored the registry info (or changed command group ID), re-create the tab.  Otherwise the ids won't matchup and the tab will be blank
                {
                    bool res = iCmdMgr.RemoveCommandTab(cmdTab);
                    cmdTab = null;
                }

                if (cmdTab == null)
                {
                    cmdTab = iCmdMgr.AddCommandTab(type.SWToInt(), groupData.Title);
                    switch (type)
                    {
                        case swDocumentTypes_e.swDocPART:
                            AddCmdbox(tabIds[0], ref cmdGroup, ref cmdTab);
                            break;
                        case swDocumentTypes_e.swDocASSEMBLY:
                            AddCmdbox(tabIds[1], ref cmdGroup, ref cmdTab);
                            break;
                        case swDocumentTypes_e.swDocDRAWING:
                            AddCmdbox(tabIds[2], ref cmdGroup, ref cmdTab);
                            break;
                        default:
                            throw new InvalidOperationException($"Can not add CommandTabBox with {type.ToString()}");
                    }
                    cmdTab.Visible = true;
                    cmdTab.Active = true;
                    var obj = cmdTab.CommandTabBoxes() as object[];
                    int count = cmdTab.GetCommandTabBoxCount();
                    foreach (CommandTabBox item in obj)
                    {
                        item.GetCommands(out object ids, out object styles);
                    }
                }
            }


            return cmdGroup;
        }

        #endregion

        #region private methods

        /// <summary>
        /// 添加单个命令
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="cmdGroup"></param>
        /// <param name="CommandIndex"></param>
        /// <returns></returns>
        private KeyValuePair<int, KeyValuePair<CommandType, int>> AddCommnad(ILifetimeScope scope, Type type, ref ICommandGroup cmdGroup, int CommandIndex)
        {
            var obj = scope.Resolve(type);

            var commandsAttr = type.GetCustomAttribute<SWCommandAttribute>();
            var flyoutAttr = type.GetCustomAttribute<SWFlyoutCommandAttribute>();

            if (commandsAttr == null && flyoutAttr == null)
            {
                throw new MissingMemberException($"The type :{nameof(type.FullName)} missing {nameof(SWCommandAttribute)} or {nameof(SWFlyoutCommandAttribute)}");
            }
            if (commandsAttr != null && flyoutAttr != null)
            {
                throw new InvalidOperationException($"The type :{nameof(type.FullName)} cannot has  {nameof(SWCommandAttribute)} and {nameof(SWFlyoutCommandAttribute)}");
            }
            if (commandsAttr != null) //普通按钮
            {
                int idIndex = _addinCommand.AddSWCommand(cmdGroup, commandsAttr.Guid, commandsAttr.Name, commandsAttr.Postion, commandsAttr.Hint, commandsAttr.ToolTip,
                    commandsAttr.ImageListIndex == -1 ? CommandIndex : commandsAttr.ImageListIndex, CommandIndex, commandsAttr.MenuTBOption.SWToInt());
                //CommandIndex++;

                if (!_addinCommand.CommandInstances.ContainsKey(commandsAttr.Guid))
                {
                    _addinCommand.CommandInstances.Add(commandsAttr.Guid, scope.Resolve(type));
                }

                return new KeyValuePair<int, KeyValuePair<CommandType, int>>(idIndex, new KeyValuePair<CommandType, int>(CommandType.Command, commandsAttr.TextType.SWToInt()));
            }
            else  //下拉按钮
            {
                IFlyoutCommand flyoutCMD = default;
                //创建下拉组
                var flyoutGroup = _addinCommand.CreatSWFlyoutGroup(CommandIndex, flyoutAttr.Guid,
                    flyoutAttr.Title, flyoutAttr.ToolTip, flyoutAttr.Hint,
                    cmdGroup.SmallMainIcon, cmdGroup.LargeMainIcon, cmdGroup.SmallIconList, cmdGroup.LargeIconList
                    );
                //CommandIndex++;
                if (!_addinCommand.CommandInstances.ContainsKey(flyoutAttr.Guid))
                {
                    var flyoutObj = scope.Resolve(type);
                    flyoutCMD = flyoutObj as IFlyoutCommand;
                    if (flyoutCMD != null)
                    {
                        flyoutCMD.FlyoutCMDId = flyoutGroup.CmdID;
                        flyoutCMD.FlyoutGroup = flyoutGroup;
                    }
                    else
                    {
                        throw new NotImplementedException($"command:{type.FullName} not implemented interface:{nameof(IFlyoutCommand)}");
                    }
                    _addinCommand.CommandInstances.Add(flyoutAttr.Guid, flyoutObj);
                }

                //下拉文档中的Commands
                var commands = flyoutAttr.Commands;
                if (commands != null && flyoutGroup != null)
                {
                    foreach (var command in commands)
                    {
                        var flyoutCMDAttr = command.GetCustomAttribute<SWCommandAttribute>();
                        if (flyoutCMDAttr == null)
                        {
                            throw new MissingMemberException($"The type :{type.FullName}'s FlyoutCommandAttribute:{command.FullName} missing {nameof(SWCommandAttribute)} or {nameof(SWFlyoutCommandAttribute)}");
                        }

                        _addinCommand.AddFlyoutCommand(flyoutGroup, flyoutCMDAttr.Guid, flyoutCMDAttr.Name, flyoutCMDAttr.Hint, flyoutCMDAttr.ImageListIndex == -1 ? CommandIndex : flyoutCMDAttr.ImageListIndex, command);

                    }
                }
                else
                {
                    throw new MissingMemberException($"flyoutCommand:{type.FullName} donot has commands");
                }
                flyoutCMD?.Execute(null);
                //flyoutGroup.FlyoutType = flyoutAttr.FlyoutType.SWToInt();
                return new KeyValuePair<int, KeyValuePair<CommandType, int>>(flyoutGroup.CmdID, new KeyValuePair<CommandType, int>(CommandType.FlyoutCommand, flyoutAttr.TextType));
            }
        }

        private void AddCmdbox(List<Dictionary<int, KeyValuePair<CommandType, int>>> tabIdList, ref ICommandGroup cmdGroup, ref CommandTab cmdTab)
        {
            int index = 0;
            foreach (var boxIds in tabIdList)
            {
                List<int> cmdIDs = new List<int>();
                List<int> TextType = new List<int>();

                CommandTabBox cmdBox = cmdTab.AddCommandTabBox();
                foreach (var cmdId in boxIds)
                {
                    switch (cmdId.Value.Key)
                    {
                        case CommandType.Command:
                            cmdIDs.Add(cmdGroup.get_CommandID(cmdId.Key));
                            break;
                        case CommandType.FlyoutCommand:
                            cmdIDs.Add(cmdId.Key);
                            break;
                    }
                    TextType.Add(cmdId.Value.Value);
                    index++;
                }
                bool result = cmdBox.AddCommands(cmdIDs.ToArray(), TextType.ToArray());

            }
        }

        /// <summary>
        /// 比较生成的CMD 和 注册表中的ID
        /// </summary>
        /// <param name="storedIDs"></param>
        /// <param name="addinIDs"></param>
        /// <returns></returns>
        private bool CompareIDs(int[] storedIDs, int[] addinIDs)
        {
            List<int> storedList = new List<int>(storedIDs);
            List<int> addinList = new List<int>(addinIDs);

            addinList.Sort();
            storedList.Sort();

            if (addinList.Count != storedList.Count)
            {
                return false;
            }
            else
            {

                for (int i = 0; i < addinList.Count; i++)
                {
                    if (addinList[i] != storedList[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion

        #endregion
    }
}
