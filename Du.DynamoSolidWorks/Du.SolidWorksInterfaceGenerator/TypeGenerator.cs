using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Du.SolidWorksInterfaceGenerator
{


    public class TypeGenerator
    {
        public const string SolidWorksNameSpace = "SolidWorks.Interop.sldworks";


        private string CSFileData;

        private List<string> NameSpaces = new List<string>();

        private List<string> PropertiesStr = new List<string>();

        private List<string> MethodsStr = new List<string>();

        private string NameSapce = "DynamoSolidWorks";

        public TypeGenerator(Type typeToWrapper)
        {
            TypeToWrapper = typeToWrapper;
        }

        public Type TypeToWrapper { get; private set; }

        public string Generate()
        {
            CSFileData = string.Empty;

            DataInit();

            AddNameSpaces();

            CSFileData += $"\nnamespace {NameSapce}\n{{\n";

            AddClassWrapper();

            var properties = TypeToWrapper.GetProperties();

            foreach (var item in properties)
            {
                AddPropertiesToMethod(item);
            }

            var methods = TypeToWrapper.GetMethods();

            foreach (var item in methods)
            {
                AddMethods(item);
            }

            var className = TypeToWrapper.FullName.Split('.').Last();
            string mainClassName = className + "Interface";

            ClassModel mainClassModel = new ClassModel(PropertiesStr, MethodsStr, mainClassName);

            CSFileData += mainClassModel.GetClassData(true);

            //namespace结尾
            CSFileData += "\n}";

            return CSFileData;
        }

        private void DataInit()
        {
            NameSpaces.Add("using SolidWorks.Interop.sldworks;");
            NameSpaces.Add("using System;");
            NameSpaces.Add("using System.Collections.Generic;");
            NameSpaces.Add("using System.Linq;");
            NameSpaces.Add("using SolidWorks.Interop.swconst;");

            NameSpaces.Add("using DynamoSolidWorks;");
            NameSpaces.Add("using Du.SolidWorks.Extension;");
            NameSpaces.Add("using Autodesk.DesignScript.Runtime;");
            NameSpaces.Add("using Du.DynamoSolidWorks.Nodes;");
        }

        private void AddNameSpaces()
        {
            foreach (var item in NameSpaces)
            {
                CSFileData += item + "\n";
            }
        }

        private void AddClassWrapper()
        {
            var className = TypeToWrapper.FullName.Split('.').Last();
            string classWrapperName = className + "Object";

            ClassModel model = new ClassModel(classWrapperName);

            model.Properties.Add($"         public {className} {className}Instance {{ get; set; }}");

            model.Methods.Add($"        public {classWrapperName}({className} {className}instance)\n        {{\n                {className}Instance = {className}instance;\n        }}");

            CSFileData += (model.GetClassData(false) + "\n");
        }

        private void AddMethods(MethodInfo item)
        {
            if (item.Name.Contains("get_") || item.Name.Contains("set_"))
            {
                return;
            }

            var className = TypeToWrapper.FullName.Split('.').Last();
            string classWrapperName = className + "Object";
            string classWrapperParamterName = className + "instance";

            var returnName = item.ReturnType?.Name;
            var returnNameWrapper = returnName == "void" ? "void" : item.ReturnType.FullName.Contains("SolidWorks.Interop.sldworks") ? returnName + "Object" : returnName;

            if (returnNameWrapper.ToLower() != "void" && returnNameWrapper.FirstOrDefault() != 'I' && item.ReturnType.FullName.Contains("SolidWorks.Interop.sldworks"))
            {
                returnNameWrapper = "I" + returnNameWrapper;
            }

            //传入的第一个参数

            string MethodHead = $"  public static {returnNameWrapper} " + item.Name + "(";



            //添加第一个封装参数
            MethodHead += $"{classWrapperName} {classWrapperParamterName}";

            var paramaters = item.GetParameters();

            string apiNameParameter = string.Empty;

            foreach (var para in paramaters)
            {
                if (para.ParameterType.FullName.Contains(SolidWorksNameSpace))
                {
                    MethodHead += $",{para.ParameterType.Name}Object {para.Name}";
                }
                else
                {
                    MethodHead += $",{para.ParameterType.Name} {para.Name}";
                }

                apiNameParameter = string.IsNullOrEmpty(apiNameParameter) ? apiNameParameter + para.Name : apiNameParameter + ("," + para.Name);
            }

            string MethodMain = string.Empty;

            if (returnName == "void")
            {
                MethodMain = $")\n      {{\n            {classWrapperParamterName}.{className}Instance.{item.Name}();\n        }}";
            }
            else
            {
                if (item.ReturnType.FullName.Contains("SolidWorks.Interop.sldworks"))
                {
                    MethodMain = $")\n     {{\n            return new {returnNameWrapper}({classWrapperParamterName}.{className}Instance.{item.Name}({apiNameParameter}));\n       }}";
                }
                else
                {
                    MethodMain = $")\n     {{\n            return {classWrapperParamterName}.{className}Instance.{item.Name}({apiNameParameter});\n       }}";
                }
            }

            MethodsStr.Add(MethodHead + MethodMain);
        }

        private void AddPropertiesToMethod(PropertyInfo item)
        {
            if (item.Name.Contains("get_") || item.Name.Contains("set_"))
            {
                return;
            }

            var className = TypeToWrapper.FullName.Split('.').Last();
            string classWrapperName = className + "Object";
            string classWrapperParamterName = className + "instance";

            var returnName = item.PropertyType?.Name;

            var returnNameWrapper = item.PropertyType.FullName.Contains("SolidWorks.Interop.sldworks") ? returnName + "Object" : returnName;

            if (returnNameWrapper.FirstOrDefault() != 'I' && item.PropertyType.FullName.Contains("SolidWorks.Interop.sldworks"))
            {
                returnNameWrapper = "I" + returnNameWrapper;
            }

            //传入的第一个参数

            string MethodHead = $"  public static {returnNameWrapper} " + item.Name + "(";

            string MethodMain = string.Empty;

            if (item.PropertyType.FullName.Contains("SolidWorks.Interop.sldworks"))
            {
                MethodMain = $")\n      {{\n            return new {returnNameWrapper}({classWrapperParamterName}.{className}Instance.{item.Name});\n      }}";

            }
            else
            {
                MethodMain = $")\n      {{\n            return {classWrapperParamterName}.{className}Instance.{item.Name};\n      }}";
            }

            //添加第一个封装参数
            MethodHead += $"{classWrapperName} {classWrapperParamterName}";


            PropertiesStr.Add(MethodHead + MethodMain);
        }
    }
}
