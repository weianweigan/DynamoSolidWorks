using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xarial.XCad.SolidWorks.Enums;

namespace SldWorksNodes.EquationMgr
{
    public class Equation
    {
        #region Fields
        private readonly IEquationMgr _equationMgr;
        #endregion

        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public Equation(int index, string value, IEquationMgr equationMgr)
        {
            Index = index;
            Value = value;
            _equationMgr = equationMgr;
        }
        #endregion

        #region Query
        public int Index { get; }

        public string Value { get; private set; }
        #endregion

        #region Create
        public static Equation ByIndex(int index)
        {
            if(index < 0)
                return null;

            var doc = SwContextUtil.GetActivDocContext();
            var equMgr = doc.GetEquationMgr();
            var count = equMgr.GetCount();

            if (index >= count)
            {
                throw new IndexOutOfRangeException($"Equation count:{count},out of range");
            }
            var equation = equMgr.Equation[index];

            return new Equation(index,equation,equMgr);
        }

        public static List<Equation> All()
        {
            var doc = SwContextUtil.GetActivDocContext();
            var equMgr = doc.GetEquationMgr();
            var count = equMgr.GetCount();

            List<Equation> equations = new List<Equation>();
            for (int i = 0; i < count; i++)
            {
                var equation = equMgr.Equation[i];

                equations.Add(new Equation(i, equation,equMgr));
            }

            return equations;
        }
        #endregion

        #region Action
        public bool SetValue(string equation)
        {
            var count = _equationMgr.GetCount();

            if (Index >= count)
            {
                throw new IndexOutOfRangeException($"Equation count:{count},out of range");
            }

            _equationMgr.Equation[Index] = equation;

            if (_equationMgr.Equation[Index] == equation)
            {
                Value = equation;
                return true;
            }
            else
                return false;
        }

        public bool SetGobalValue(double value)
        {
            if (!IsGobalVar())
            {
                throw new Exception(Properties.Resources.NotGobalVar);
            }

            var data = Value.Split('=');
            if (data.Length >= 2)
            {
                data[1] = value.ToString();
            }
            else
            {
                return false;
            }

            var result = data[0]+"= " +data[1];
            for (int i = 2; i < data.Length; i++)
            {
                result += data[i];
            }

            return SetValue(result);
        }

        public bool IsGobalVar()
        {
            var version = SldContextManager.SwApplication.Version.Major;
            if ((int)version < (int)SwVersion_e.Sw2017)
                throw new NotSupportedException(String.Format(Properties.Resources.SwVersionNotSupport, version));

            return  _equationMgr.GlobalVariable[Index];
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Index}:{Value}";
        }
        #endregion
    }
}
