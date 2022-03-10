using Dynamo.Logging;
using Dynamo.Updates;

namespace DynamoSldWorks.Model
{
    public class SwUpdateManager : IUpdateManager
    {
        public BinaryVersion ProductVersion => BinaryVersion.FromString("");

        public BinaryVersion AvailableVersion => BinaryVersion.FromString("");

        public IAppVersionInfo UpdateInfo { get; set; }

        public bool IsUpdateAvailable => false;

        public bool CheckNewerDailyBuilds { get; set; } = false;

        public bool ForceUpdate { get; set; } = false;

        public IUpdateManagerConfiguration Configuration => null;

        public event UpdateDownloadedEventHandler UpdateDownloaded;
        public event ShutdownRequestedEventHandler ShutdownRequested;
        public event LogEventHandler Log;

        public void CheckForProductUpdate(IAsynchronousRequest request)
        {
        }

        public void HostApplicationBeginQuit()
        {
        }

        public void OnLog(LogEventArgs args)
        {
        }

        public void QuitAndInstallUpdate()
        {
        }

        public void RegisterExternalApplicationProcessId(int id)
        {
        }

        public void UpdateDataAvailable(IAsynchronousRequest request)
        {
        }
    }
}
