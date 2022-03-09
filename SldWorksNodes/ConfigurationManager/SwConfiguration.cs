using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.ConfigurationManager
{
    /// <summary>
    /// Configuration In SolidWorks
    /// </summary>
    public class SwConfiguration:SwNodeModel<IConfiguration>
    {
        internal SwConfiguration(IConfiguration activeConfiguration)
        {
            SwObject = activeConfiguration;
        }

        /// <summary>
        /// Get activedoc's activeconfiguration
        /// </summary>
        /// <returns></returns>
        public static SwConfiguration ActiveConfiguration()
        {
            var doc = Document.Document.Current();

            return doc.ActiveConfiguration();
        }

        public string Name
        {
            get
            {
                return SwObject?.Name;
            }
            set
            {
                if (SwObject != null)
                    SwObject.Name = value;
            }
        }

        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return Name;
        }


    }
}
