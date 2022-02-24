using Dynamo.Extensions;
using Dynamo.Interfaces;
using Dynamo.Scheduler;
using Dynamo.Updates;
using Greg;
using System.Collections.Generic;

namespace DynamoSldWorks.Model
{
    public partial class SldDynamoModel
    {
        public class SldStartConfiguation : IStartConfiguration
        {
            public SldStartConfiguation()
            {
                ProcessMode = TaskProcessMode.Asynchronous;
                DynamoCorePath = SwAddin.DynamoCorePath;
                DynamoHostPath = SwAddin.DynamoCorePath;
            }

            public string Context {get;set;}

            public string DynamoCorePath {get;set;}

            public string DynamoHostPath {get;set;}

            public IPreferences Preferences {get;set;}

            public IPathResolver PathResolver {get;set;}

            public bool StartInTestMode {get;set;}

            public IUpdateManager UpdateManager {get;set;}

            public ISchedulerThread SchedulerThread {get;set;}

            public string GeometryFactoryPath {get;set;}

            public IAuthProvider AuthProvider {get;set;}

            public IEnumerable<IExtension> Extensions {get;set;}

            public TaskProcessMode ProcessMode { get; set; }

            public bool IsHeadless {get;set;}
        }
    }
}
