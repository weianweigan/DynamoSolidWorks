using System.Collections.Generic;

namespace Du.SolidWorksInterfaceGenerator
{
    public class ClassModel
    {

        public ClassModel(List<string> methods, List<string> propertys, string className)
        {
            Methods = methods;
            Properties = propertys;
            ClassName = className;
        }

        public ClassModel(string className)
        {
            Methods = new List<string>();
            Properties = new List<string>();
            ClassName = className;
        }
        public List<string> Methods { get; set; }

        public List<string> Properties { get; set; }

        public string ClassName { get; set; }

        public string GetClassData(bool IsClassStatic)
        {
            string classHead = IsClassStatic ? $"   public static class {ClassName}\n   {{\n" : $"   public class {ClassName}\n    {{\n";

            string classEnd = "    }";

            string classStr = classHead;

            foreach (var item in Properties)
            {
                classStr = classStr + item + "\n";
            }

            foreach (var item in Methods)
            {
                classStr = classStr + item + "\n";
            }

            classStr += classEnd;

            return classStr;
        }
    }
}
