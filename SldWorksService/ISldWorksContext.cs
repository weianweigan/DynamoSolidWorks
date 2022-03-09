using SolidWorks.Interop.sldworks;
using Xarial.XCad.SolidWorks;

namespace SldWorksService
{
    /// <summary>
    /// Context used for commuiate with SldWorks
    /// </summary>
    public interface ISldWorksContext
    {
        /// <summary>
        /// Interface to visit SldWorks
        /// </summary>
        ISldWorks Sw { get;}

        ISwApplication SwApplication { get; }
    }
}
