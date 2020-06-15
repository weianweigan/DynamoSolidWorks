using Autofac;
using Du.SolidWorks;
using Du.SolidWorks.Interface;
using Du.SwAddinBase.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Du.SwAddinBase.Extension
{

    public static class SolidWorksRibbonExtension
    {
        private static List<GroupData> groupDatas;

        /// <summary>
        /// 将所有以Command结尾的类注册到容器中
        /// </summary>
        /// <param name="builder"></param>
        public static void AddCommandsEndWithCommand(this ContainerBuilder builder, Assembly assembly)
        {
            builder.RegisterAssemblyTypes(assembly).Where(t => t.Name.EndsWith("Command")).SingleInstance();
        }

        /// <summary>
        /// 将SolidWorks Ribbon页添加到容器中
        /// </summary>
        /// <typeparam name="TPart"></typeparam>
        /// <typeparam name="TAssembly"></typeparam>
        /// <typeparam name="TDrawing"></typeparam>
        /// <param name="builder"></param>
        public static void AddCommandTab<TPart, TAssembly, TDrawing>(this ContainerBuilder builder,
            string Title, string ToolTip, string HintString,
            string LargeIconList, string SmallIconList, string LargeMainIcon, string SmallMainIcon
            , Assembly iconAssembly)
        {
            groupDatas = groupDatas ?? new List<GroupData>();

            builder.RegisterType<TPart>();
            builder.RegisterType<TAssembly>();
            builder.RegisterType<TDrawing>();

            groupDatas.Add(new GroupData()
            {
                Title = Title,
                ToolTip = ToolTip,
                Hint = HintString,
                IconAssembly = iconAssembly,
                TabStyles = new Type[] { typeof(TPart), typeof(TAssembly), typeof(TDrawing) },
                Icons = new string[] { LargeIconList, SmallIconList, LargeMainIcon, SmallMainIcon }
            }
                );

            builder.RegisterType<SWCMDGroupService>().As<ISWCMDGroupService>().SingleInstance();
        }

        /// <summary>
        /// 使用SolidWorks Ribbon页
        /// </summary>
        /// <param name="container"></param>
        public static void UseCommandTab(this IContainer container)
        {
            try
            {
                using (var scope = container.BeginLifetimeScope())
                {
                    var service = scope.Resolve<ISWCMDGroupService>();
                    foreach (var item in groupDatas)
                    {
                        service.AddCommandGroup(item, scope);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
