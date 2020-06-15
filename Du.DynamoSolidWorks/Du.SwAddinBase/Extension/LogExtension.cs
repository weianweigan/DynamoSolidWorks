using Autofac;
using Serilog;
using System;

namespace Du.SwAddinBase.Extension
{
    public static class LogExtension
    {
        /// <summary>
        /// 注入日志服务
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="loggerConfig"></param>
        public static void AddLogService(this ContainerBuilder builder, Action<LoggerConfiguration> loggerConfig)
        {
            var logger = new LoggerConfiguration();
            loggerConfig?.Invoke(logger);
            Log.Logger = logger.CreateLogger();
            Log.Information("添加SPVD日志服务");
            builder.RegisterInstance(Log.Logger).As<ILogger>();
        }

        /// <summary>
        /// 注入默认日志服务
        /// </summary>
        /// <remarks>
        ///  默认 最小日志级别 information
        ///  写入到Console
        ///  写入到文件 以天为单位
        /// </remarks>
        /// <param name="builder"></param>
        /// <param name="LogFileName">例如 "SPVDLog.txt"</param>
        public static void AddLogService(this ContainerBuilder builder, string LogFileName = "Log.txt")
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File(LogFileName,
                rollingInterval: RollingInterval.Day,
                rollOnFileSizeLimit: true)
            .CreateLogger();
            Log.Information("添加日志服务");
            builder.RegisterInstance(Log.Logger).As<ILogger>();
        }

        /// <summary>
        /// 使用日志服务
        /// </summary>
        /// <param name="container"></param>
        public static ILogger UseSeriLogger(this IContainer container)
        {
            return container.Resolve<ILogger>();
        }
    }
}
