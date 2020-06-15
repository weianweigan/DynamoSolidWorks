using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du.SwAddinBase
{
    public class SwAddinDemo : AddinBase
    {
        public override void ConnectToSWPre()
        {
            
        }

        public override void ConnectToSWPost(SldWorks swApp)
        {
            //ContainerBuilder = new SWContainer.SWContainerBuilder().
               // AddAddin(this,iCmdMgr).UseStartUp<Startup>();
        }



        public override void DisConnectSWPost()
        {
            throw new NotImplementedException();
        }



        public override void OnRemoveCommandMgr()
        {
            throw new NotImplementedException();
        }
    }
}
