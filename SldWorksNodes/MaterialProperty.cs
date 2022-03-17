using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Autodesk.DesignScript.Runtime;
using ProtoCore;

namespace SldWorksNodes
{
    public class MaterialProperty
    {
        #region Ctor
        public MaterialProperty(
            double r,
            double g,
            double b,
            double ambient = 1, 
            double diffuse = 1, 
            double specular = 0.8, 
            double shininess= 0.1, 
            double transparency = 0, 
            double emission = 0)
        {
            R = r;
            G = g;
            B = b;
            Ambient = ambient;
            Diffuse = diffuse;
            Specular = specular;
            Shininess = shininess;
            Transparency = transparency;
            Emission = emission;
        }
        #endregion

        #region Create

        internal static MaterialProperty ByArrary(double[] array)
        {
            if (array == null || array.Length < 9)
                return null;

            return new MaterialProperty(
                    array[0]*255,array[1]*255,array[2]*255,
                    array[3], array[4], array[5], array[6],array[7],
                    array[8]
                );
        }
        #endregion

        #region Query
        public double R { get; set; }

        public double G { get; set; }

        public double B { get; set; }

        public double Ambient { get; set; }

        public double Diffuse { get; set; }

        public double Specular { get; set; }

        public double Shininess { get; set; }

        //使用ARGB 不使用透明度
        public double Transparency { get; set;}

        public double Emission { get; set; }
        #endregion

        #region Methods
        [IsVisibleInDynamoLibrary(false)]
        public double[] ToArray()
        {
            return new double[]
            {
                R/255,
                G/255,
                B/255,
                Ambient,
                Diffuse,
                Specular,
                Shininess,
                Transparency,
                Emission,
            };
        }

        public override string ToString()
        {
            return $"Color:{R}-{G}-{B},{nameof(Ambient)}:{Ambient},{nameof(Diffuse)}:{Diffuse},{nameof(Specular)}:{Specular},{nameof(Shininess)}:{Shininess},{nameof(Emission)}:{Emission}";
        }
        #endregion
    }
}
