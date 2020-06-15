using SolidWorks.Interop.sldworks;

namespace Du.SolidWorks.Interface
{
    public interface IFlyoutCommand
    {
        int FlyoutCMDId { get; set; }

        IFlyoutGroup FlyoutGroup { get; set; }

        void Execute(object parameter);
    }
}
