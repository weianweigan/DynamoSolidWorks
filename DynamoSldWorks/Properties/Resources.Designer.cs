﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamoSldWorks.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DynamoSldWorks.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Close 的本地化字符串。
        /// </summary>
        public static string Close {
            get {
                return ResourceManager.GetString("Close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap id {
            get {
                object obj = ResourceManager.GetObject("id", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap logo_square_32x32 {
            get {
                object obj = ResourceManager.GetObject("logo_square_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 Open Dynamo 的本地化字符串。
        /// </summary>
        public static string OpenDynamo {
            get {
                return ResourceManager.GetString("OpenDynamo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Samples 的本地化字符串。
        /// </summary>
        public static string Samples {
            get {
                return ResourceManager.GetString("Samples", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Start new version dynamo need update a dll in solidworks, before update. SolidWorks will be closed.Do you want to continue? 的本地化字符串。
        /// </summary>
        public static string StartNewVersionNeedReplaceDll {
            get {
                return ResourceManager.GetString("StartNewVersionNeedReplaceDll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Start SandBox 的本地化字符串。
        /// </summary>
        public static string StartSandBox {
            get {
                return ResourceManager.GetString("StartSandBox", resourceCulture);
            }
        }
    }
}
