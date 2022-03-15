using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.EquationMgr
{
    public class Equation
    {
        public Equation(int index, string value)
        {
            Index = index;
            Value = value;
        }

        [IsVisibleInDynamoLibrary(false)]
        public int Index { get; }

        [IsVisibleInDynamoLibrary(false)]
        public string Value { get; private set; }

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

            return new Equation(index,equation);
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

                equations.Add(new Equation(i, equation));
            }

            return equations;
        }

        public bool SetValue(string equation)
        {
            var doc = SwContextUtil.GetActivDocContext();
            var equMgr = doc.GetEquationMgr();
            var count = equMgr.GetCount();

            if (Index >= count)
            {
                throw new IndexOutOfRangeException($"Equation count:{count},out of range");
            }

            equMgr.Equation[Index] = equation;

            if (equMgr.Equation[Index] == equation)
            {
                Value = equation;
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return $"{Index}:{Value}";
        }
    }
}
