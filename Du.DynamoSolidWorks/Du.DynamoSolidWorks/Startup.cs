using Autofac;
using Du.SolidWorks;
using Du.SolidWorks.Extension;
using Du.SwAddinBase;
using Du.SwAddinBase.Extension;
using Serilog;
using System.Reflection;
using System.Windows.Input;

namespace Du.DynamoSolidWorks
{
    public class Startup : IStartup
    {
        #region services
        //插件
        private ISolidWorksAddin _addin;
        private ILogger logger;
        #endregion


        public Startup()
        {
            //this._addin = addin;
        }


        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureServices(ContainerBuilder builder)
        {

            builder.AddCommandsEndWithCommand(Assembly.GetExecutingAssembly());

            builder.AddCommandTab<PartCommandsConfig, AssemblyCommandsConfig, DrawingCommandsConfig>(
                "DynamoSolidWorks", "Dynamo for SolidWorks", "Visual Programming Powered By Dynamo",
                "Du.DynamoSolidWorks.ToolbarLarge.png", "Du.DynamoSolidWorks.ToolbarSmall.png",
                "Du.DynamoSolidWorks.MainIconLarge.png", "Du.DynamoSolidWorks.MainIconSmall.png", typeof(Startup).Assembly
                );

            //设置日志
            builder.AddLogService();

            //设置Dynamo
            //builder.Register<DynamoSandbox.>
        }

        /// <summary>
        /// 生成CommandGroup对象
        /// </summary>
        public void ConfigureCommands(IContainer container)
        {

            logger = container.UseSeriLogger();

            container.UseCommandTab();


            using (var scope = container.BeginLifetimeScope())
            {
                _addin = scope.Resolve<ISolidWorksAddin>();
            }
        }


        #region 命令管道

        public void CommandExcute(object CommandObj, string cmdGuid)
        {
            logger?.Information("激活命令:{0}", cmdGuid);

            //执行命令
            CommandObj?.
                CastObj<ICommand>()?.Execute(cmdGuid);
        }

        public bool CommandEnable(object CommandObj, string cmdGuid)
        {
            logger?.Information("命令检查:{0}", cmdGuid);

            return CommandObj?.
                CastObj<ICommand>()?.
                CanExecute(cmdGuid) == true ? true : false;
        }



        #endregion
    }
}
