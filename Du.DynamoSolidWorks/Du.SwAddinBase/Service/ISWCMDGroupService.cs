
using Autofac;
using SolidWorks.Interop.sldworks;

namespace Du.SolidWorks.Interface
{
    public interface ISWCMDGroupService
    {
        ICommandGroup AddCommandGroup(GroupData groupData, ILifetimeScope scope);
    }
}
