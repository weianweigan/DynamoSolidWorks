using Xunit;
using SldWorksNodes.EquationMgr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodesTests;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.EquationMgr.Tests
{
    public class EquationTests:SwObjectTest<IEquationMgr>
    {
        [Fact()]
        public void SetGobalValueTest()
        {
            //SwMock.SetupGet(p => p.Equation[0])
              //  .Returns("");

            var equation = new Equation(0, "\"B\" = 5", SwMock.Object);

            Assert.True(equation.SetGobalValue(10));
            Assert.Equal("\"B\" = 10", equation.Value);
        }
    }
}