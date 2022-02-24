using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xarial.XCad;

namespace DynamoSldWorks
{
    /// <summary>
    /// Context used for commuiate with SldWorks
    /// </summary>
    public interface ISldWorksContext
    {
        /// <summary>
        /// Interface to visit SldWorks
        /// </summary>
        ISldWorks App { get;}

        /// <summary>
        /// Custom Services
        /// </summary>
        IXServiceCollection Services { get; }
    }
}
