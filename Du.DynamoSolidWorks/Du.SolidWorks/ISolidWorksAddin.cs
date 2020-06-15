using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace Du.SolidWorks
{
    public interface ISolidWorksAddin
    {
        SldWorks SwApp { get; }

        MathUtility swMath { get; }

    }

    public interface ISWAddinCommand
    {
        Dictionary<string, object> CommandInstances { get; set; }
        List<int> CmdGroupIDs { get; set; }

        int AddFlyoutCommand(IFlyoutGroup flyoutGroup, string guid, string name, string hint, int imageListIndex, Type commandType);
        int AddSWCommand(ICommandGroup cmdGroup, string guid, string name, int postion, string hint, string tooltip, int imageListIndex, int commandIndex, int menuOption);
        IFlyoutGroup CreatSWFlyoutGroup(int commandIndex, string guid, string title, string tooltip, string hint, string smallMainIcon, string largeMainIcon, string smallIconList, string largeIconList);

    }
}
