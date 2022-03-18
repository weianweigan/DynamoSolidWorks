using Xunit;
using SldWorksNodes.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SolidWorks.Interop.sldworks;
using SldWorksNodesTests;

namespace SldWorksNodes.Document.Tests
{
    public class DocumentTests:SwObjectTest<IModelDoc2>
    {
        [Fact()]
        public void ToStringTest()
        {
            SwMock.Setup(p => p.GetTitle())
                .Returns(() => "Sw.sldprt");

            var doc = new Document(SwMock.Object);

            Assert.True(doc.ToString() == "Sw.sldprt");
        }
    }
}