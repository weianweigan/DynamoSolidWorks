using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SldWorksNodes.Util;
using SldWorksService;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodesTests
{
    public class SwObjectTest<TSwInterface>
        where TSwInterface : class
    {
        public SwObjectTest()
        {
            MockSwContext();
        }

        private static void MockSwContext()
        {
            var sw = new Mock<ISldWorks>();
            var modelDoc = new Mock<ModelDoc2>();
            var modelDocEx = new Mock<ModelDocExtension>();

            modelDocEx.Setup(p => p.GetPersistReference3(""))
                .Returns("");

            modelDoc.Setup(p => p.Extension)
                .Returns(modelDocEx.Object);

            sw.Setup(p => p.IActiveDoc2)
                .Returns(modelDoc.Object);

            var swcontext = new Mock<ISldWorksContext>();
            swcontext.Setup(p => p.Sw)
                .Returns(sw.Object);

            SldContextManager.Init(swcontext.Object);
        }

        public Mock<TSwInterface> SwMock { get; } = new Mock<TSwInterface>();
    }
}
