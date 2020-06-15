using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Du.SolidWorksInterfaceGenerator
{
    class Program
    {
        static string Direc = @"D:\weigan\repos\DynamoSolidWorks\Du.DynamoSolidWorks\Du.DynamoSolidWorks.Nodes\SolidWorksInterface";
        static void Main(string[] args)
        {
            var ass = Assembly.LoadFrom(@"D:\weigan\repos\DynamoSolidWorks\Du.DynamoSolidWorks\packages\SolidWorks2016\SolidWorks.Interop.sldworks.dll");
            var types = ass.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine(item.FullName);

                var interfaceName = item.FullName.Split('.').Last();
                if (interfaceName.First() == 'I' && !interfaceName.Contains("Class"))
                {
                    Console.WriteLine("Generate Interface -- {0}", interfaceName);

                    TypeGenerator typeGenerator = new TypeGenerator(item);

                    var str = typeGenerator.Generate();

                    Console.WriteLine("Generate Interface -- {0} Completed", interfaceName);

                    string filePath = Direc + "\\" + item.Name + "Interface.cs";


                    StreamWriter writer = new StreamWriter(filePath);
                    writer.Write(str);
                    writer.Close();

                    Console.WriteLine("----------------------------------------------------");

                }
            }

            Console.ReadKey();
        }
    }
}
