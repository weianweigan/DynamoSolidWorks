using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes
{
    [IsVisibleInDynamoLibrary(false)]
    public class MaterialProperty
    {
        public MaterialProperty(
            Color color, 
            double ambient, 
            double diffuse, 
            double specular, 
            double shininess, 
            double transparency, 
            double emission)
        {
            Color = color;
            Ambient = ambient;
            Diffuse = diffuse;
            Specular = specular;
            Shininess = shininess;
            Transparency = transparency;
            Emission = emission;
        }

        #region Query
        public Color Color { get; set; }

        public double Ambient { get; set; }

        public double Diffuse { get; set; }

        public double Specular { get; set; }

        public double Shininess { get; set; }

        public double Transparency { get; set;}

        public double Emission { get; set; }
        #endregion

        #region Methods
        [IsVisibleInDynamoLibrary(false)]
        public double[] ToArray()
        {
            return new double[]
            {
                Color.R/255,
                Color.G/255,
                Color.B/255,
                Ambient,
                Diffuse,
                Specular,
                Shininess,
                Transparency,
                Emission,
            };
        }
        #endregion
    }
}
