using System;
using Dynamo.Logging;
using Dynamo.Updates;

namespace DynamoSldWorks.Model
{
    public class SwUpdateManager : IUpdateManager
    {
#if V1_2_0

#else
        public BinaryVersion ProductVersion => BinaryVersion.FromString("2.13.1");

        public BinaryVersion AvailableVersion => BinaryVersion.FromString("2.13.1");
#endif

        public IAppVersionInfo UpdateInfo { get; set; }

        public bool IsUpdateAvailable => false;

        public bool CheckNewerDailyBuilds { get; set; } = false;

        public bool ForceUpdate { get; set; } = false;

        public IUpdateManagerConfiguration Configuration => null;

        public Version HostVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HostName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
