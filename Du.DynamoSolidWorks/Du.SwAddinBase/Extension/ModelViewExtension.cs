using Autofac;
using Du.SwAddinBase.Service;

namespace Du.SwAddinBase.Extension
{
    public static class ModelViewExtension
    {
        public static void AddModelViewService(this ContainerBuilder builder)
        {
            builder.RegisterType<SWModelViewService>().As<ISWModelViewService>();
        }
    }
}
