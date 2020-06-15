using Autofac;
using Du.SolidWorks;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Du.SwAddinBase.Extension
{
    public static class TaskPaneExtension
    {
        private static List<Type> Panes;

        /// <summary>
        /// 添加TaskPane
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        public static void AddTaskPane<T>(this ContainerBuilder builder)
            where T : UIElement
        {
            Panes = Panes == null ? new List<Type>() : Panes;

            Panes.Add(typeof(T));

            builder.RegisterType<T>().SingleInstance();
        }

        /// <summary>
        /// 使用添加的TaskPane
        /// </summary>
        /// <param name="container"></param>
        /// <param name="Name"></param>
        /// <param name="BitMapStr"></param>
        public static void UseTaskPane(this IContainer container, string Name, string BitMapStr = "")
        {
            if (Panes != null)
            {
                using (var scope = container.BeginLifetimeScope())
                {
                    foreach (var item in Panes)
                    {
                        var pane = scope.Resolve(item) as UIElement;
                        var addin = scope.Resolve<ISolidWorksAddin>();
                        if (pane != null && addin != null)
                        {
                            ITaskpaneView pTaskPanView;
                            var elhost = new ElementHost();
                            pTaskPanView = addin.SwApp.CreateTaskpaneView2(BitMapStr, Name);
                            elhost.Child = pane;
                            pTaskPanView.DisplayWindowFromHandlex64(elhost.Handle.ToInt64());
                        }
                        else
                        {
                            throw new NullReferenceException("Can not add TaskPane,Because can not resolve ISolidWorksAddin or Pane");
                        }
                    }
                }
            }
            else
            {
                throw new Exception($"Call {nameof(AddTaskPane)} First When Call {nameof(UseTaskPane)}");
            }
        }
    }
}
