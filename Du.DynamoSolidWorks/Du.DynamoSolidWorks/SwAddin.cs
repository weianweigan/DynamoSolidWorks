using Autofac;
using Du.SolidWorks;
using Du.SwAddinBase;
using Du.SwAddinBase.SWContainer;
using SolidWorks.Interop.sldworks;
using SolidWorksTools;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Du.DynamoSolidWorks
{
    [Guid(AddinGuid), ComVisible(true)]
    [SwAddin(
        Description = AddinDescription,
        Title = AddinTitle,
        LoadAtStartup = LoadAtStartUp
        )]
    public class SwAddin : AddinBase, ISWAddinCommand
    {
        #region Addin Const Setting
        public const string AddinGuid = "CADFCEE3-006F-4A58-81E9-AD0401027328";
        public const string AddinDescription = "Visual Programming Powered By Dynamo";
        public const string AddinTitle = "Dynamo for SolidWorks";
        public const bool LoadAtStartUp = true;
        #endregion

        #region filed

        //Callback Method Name
        private const string callbackMethodName = nameof(OnCommandClick);
        private const string enableMethodName = nameof(OnCommandEnable);

        //Startup Instance
        private IStartup _startup;

        #endregion

        #region Propertys

        public Dictionary<string, object> CommandInstances { get; set; }
        public List<int> CmdGroupIDs { get; set; }

        #endregion

        #region addin action

        //active when solidworks load our addin
        public override void ConnectToSWPost(SldWorks swApp)
        {
            ContainerBuilder = new SWContainerBuilder().
                AddAddin(this, this, iCmdMgr).UseStartUp<Startup>();
            Container = ContainerBuilder.Build();

            //solve startup from container
            using (var scope = Container.BeginLifetimeScope())
            {
                _startup = scope.Resolve<IStartup>();
            }
        }

        //active before solidworks load our addin
        public override void ConnectToSWPre()
        {
        }

        //active when solidworks close our addin
        public override void DisConnectSWPost()
        {
            //Container.Dispose();
        }

        //active when solidworks remove our commandmgr
        public override void OnRemoveCommandMgr()
        {
            CmdGroupIDs.ForEach(id =>
            {
                iCmdMgr?.RemoveCommandGroup(id);
            }
            );
        }

        #endregion

        #region Send Command to Startup

        public void OnCommandClick(string cmdId)
        {
            if (CommandInstances.ContainsKey(cmdId))
            {
                _startup.CommandExcute(CommandInstances[cmdId], cmdId);
            }
        }

        /// <summary>
        /// true 为 1 ,false 为0
        /// </summary>
        /// <param name="cmdId"></param>
        /// <returns></returns>
        public int OnCommandEnable(string cmdId)
        {
            bool result = true;
            if (CommandInstances.ContainsKey(cmdId))
            {
                result = _startup.CommandEnable(CommandInstances[cmdId], cmdId);
            }

            return result == true ? 1 : 0;
        }

        #endregion

        #region Command interface

        /*
          实现添加窗口的接口以便添加Command时可以调用，转发到SwAddin实现开实现委托方法
         */

        public int AddSWCommand(ICommandGroup cmdGroup, string guid, string name, int postion, string hint, string tooltip, int imageListIndex, int commandIndex, int menuOption)
        {
            var cmdCallbackFunc = $"{callbackMethodName}({guid})";
            var cmdEnableFunc = $"{enableMethodName}({guid})";
            return cmdGroup.AddCommandItem2(name, postion, hint, tooltip,
                    imageListIndex, cmdCallbackFunc, cmdEnableFunc, commandIndex, menuOption);

        }

        public IFlyoutGroup CreatSWFlyoutGroup(int commandIndex, string guid, string title, string tooltip, string hint, string smallMainIcon, string largeMainIcon, string smallIconList, string largeIconList)
        {
            var flyoutCallbackFunc = $"{callbackMethodName}({guid})";
            var flyoutEnableFunc = $"{enableMethodName}({guid})";
            return iCmdMgr.CreateFlyoutGroup(commandIndex,
                    title, tooltip, hint,
                    smallMainIcon, largeMainIcon, smallIconList, largeIconList,
                    flyoutCallbackFunc, flyoutEnableFunc);
        }

        public int AddFlyoutCommand(IFlyoutGroup flyoutGroup, string guid, string name, string hint, int imageListIndex, Type commandType)
        {
            var flyoutCallbackFunc = $"{callbackMethodName}({guid})";
            var flyoutEnableFunc = $"{enableMethodName}({guid})";
            int index = flyoutGroup.AddCommandItem(name, hint, imageListIndex, flyoutCallbackFunc, flyoutEnableFunc);

            if (!CommandInstances.ContainsKey(guid) && Container != null)
            {
                using (var scope = Container.BeginLifetimeScope())
                {
                    CommandInstances.Add(guid, scope.Resolve(commandType));
                }
            }

            return index;
        }

        #endregion
    }
}
