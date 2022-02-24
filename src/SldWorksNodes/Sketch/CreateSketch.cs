using Dynamo.Graph.Nodes;

namespace SldWorksNodes
{
    [NodeCategory("SldWorks")]
    public class Sketch
    {
        private string _name;

        internal Sketch(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Create a sketch in solidworks.
        /// </summary>
        /// <param name="name">Sketch's Name</param>
        /// <returns></returns>
        public static Sketch ByName(string name)
        {
            return new Sketch(name);
        }
    }
}
