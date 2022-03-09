using Dynamo.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xarial.XCad.Documents;
using Xarial.XCad.SolidWorks;

namespace DynamoSldWorks.Model
{
    public class SwSchedulerThread : ISchedulerThread
    {
        private ISwApplication _swApp;
        private IScheduler _scheduler;

        public SwSchedulerThread(ISwApplication swApp)
        {
            _swApp = swApp;
        }

        public void Initialize(IScheduler owningScheduler)
        {
            _scheduler = owningScheduler;
            _swApp.Idle += _swApp_Idle;
        }

        private void _swApp_Idle(Xarial.XCad.IXApplication app)
        {
            while (_scheduler.ProcessNextTask(false))
            {
            }
        }

        public void Shutdown()
        {
            _swApp.Idle -= _swApp_Idle;
        }
    }
}
