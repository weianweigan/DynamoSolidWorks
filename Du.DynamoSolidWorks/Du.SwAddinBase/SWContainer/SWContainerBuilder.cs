using Autofac;
using Autofac.Builder;
using Du.SolidWorks;
using SolidWorks.Interop.sldworks;

namespace Du.SwAddinBase.SWContainer
{
    public class SWContainerBuilder : ContainerBuilder
    {
        private IStartup startup;

        public SWContainerBuilder AddAddin(ISolidWorksAddin addin, ISWAddinCommand addinCommand, ICommandManager iCmdMgr)
        {
            this.RegisterInstance<ISolidWorksAddin>(addin).SingleInstance();
            this.RegisterInstance<ICommandManager>(iCmdMgr).SingleInstance();
            this.RegisterInstance<ISWAddinCommand>(addinCommand).SingleInstance();

            return this;
        }

        public SWContainerBuilder UseStartUp<T>()
            where T : IStartup, new()
        {
            startup = new T() as IStartup;

            startup.ConfigureServices(this);

            this.RegisterInstance(startup).As<IStartup>();

            return this;
        }

        public new IContainer Build(ContainerBuildOptions containerBuildOptions = ContainerBuildOptions.None)
        {
            var container = base.Build(containerBuildOptions);

            startup.ConfigureCommands(container);

            return container;
        }
    }
}
