using SolidWorks.Interop.sldworks;

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
        ISldWorks App { get;}
    }
}
