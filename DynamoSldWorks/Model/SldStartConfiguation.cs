using Dynamo.Extensions;
using Dynamo.Interfaces;
using Dynamo.Scheduler;
using Dynamo.Updates;
using Greg;
using System.Collections.Generic;
using System.Reflection;
using static Dynamo.Models.DynamoModel;

namespace DynamoSldWorks.Model
{
    public class SldStartConfiguation : IStartConfiguration
    {
        public SldStartConfiguation()
        {
            ProcessMode = TaskProcessMode.Synchronous;
            DynamoCorePath = SwAddin.DynamoCorePath;
            DynamoHostPath = SwAddin.DynamoCorePath;
        }

        public string Context { get; set; } = "SolidWorks";

        public string DynamoCorePath { get; set; }

        public string DynamoHostPath { get; set; }

        public IPreferences Preferences { get; set; }

        public IPathResolver PathResolver { get; set; } = new SwPathReSolver();

        public bool StartInTestMode { get; set; }

        public IUpdateManager UpdateManager { get; set; }

        public ISchedulerThread SchedulerThread { get; set; }

        public string GeometryFactoryPath { get; set; }

        public IAuthProvider AuthProvider { get; set; }

        public IEnumerable<IExtension> Extensions { get; set; }

        public TaskProcessMode ProcessMode { get; set; }

        public bool IsHeadless { get; set; }
    }
}
