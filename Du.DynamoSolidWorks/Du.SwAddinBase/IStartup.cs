using Autofac;

namespace Du.SwAddinBase
{
    public interface IStartup
    {
        bool CommandEnable(object CommandObj, string cmdGuid);
        void CommandExcute(object CommandObj, string cmdGuid);
        void ConfigureCommands(IContainer container);
        void ConfigureServices(ContainerBuilder builder);
    }
}
