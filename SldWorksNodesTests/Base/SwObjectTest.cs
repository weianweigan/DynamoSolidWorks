using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace SldWorksNodesTests
{
    public class SwObjectTest<TSwInterface>
        where TSwInterface : class
    {
        public Mock<TSwInterface> SwMock { get; } = new Mock<TSwInterface>();
    }
}
