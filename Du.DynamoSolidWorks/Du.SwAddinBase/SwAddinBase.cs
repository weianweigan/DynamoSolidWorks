using Autofac;
using Du.SolidWorks;
using Du.SwAddinBase.SWContainer;
using Microsoft.Win32;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using SolidWorksTools;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Du.SwAddinBase
{
    [ComVisible(true)]
    public abstract class AddinBase : ISwAddin, ISolidWorksAddin
    {

        private int addinID = 0;

        #region autofac container object

        public IContainer Container { get; set; }

        public SWContainerBuilder ContainerBuilder { get; set; }

        #endregion

        #region SolidWorks Obj

        //Static ISolidWorks Addin
        public static ISolidWorksAddin ActiveSolidWorks { get; private set; }

        public SldWorks SwApp { get; private set; }

        protected ICommandManager iCmdMgr { get; private set; }

        public MathUtility swMath { get; protected set; }

        #endregion

        #region SolidWorks Registration
        [ComRegisterFunction]
        public static void RegisterFunction(Type t)
        {
            try
            {
                var addinAttribute = t.GetCustomAttribute<SwAddinAttribute>(false);
                if (addinAttribute == null)
                {
                    throw new NullReferenceException($"Type {t.FullName} doesn't have {nameof(SwAddinAttribute)}.");
                }
                /*
                        var publicKey = t.Assembly.GetName().GetPublicKeyToken();
                        if (publicKey.Length == 0)
                            throw new Exception(
                                "I think you forgot to strongly name your addin. Please See https://github.com/Weingartner/SolidworksAddinFramework#strong-naming-and-plugin-robustness-in-the-face-of-confliciting-dlls");
                                */
                var hklm = Registry.LocalMachine;
                var hkcu = Registry.CurrentUser;

                var addinKey = CreateSubKey(hklm, "SOFTWARE\\SolidWorks\\Addins\\{" + t.GUID + "}");
                addinKey.SetValue(null, 0);

                addinKey.SetValue("Description", addinAttribute.Description);
                addinKey.SetValue("Title", addinAttribute.Title);

                var addinStartupKey = CreateSubKey(hkcu, "Software\\SolidWorks\\AddInsStartup\\{" + t.GUID + "}");
                addinStartupKey.SetValue(null, Convert.ToInt32(addinAttribute.LoadAtStartup), RegistryValueKind.DWord);
            }
            catch (Exception e)
            {
                Console.WriteLine($"There was a problem registering this dll: {e}");
                //MessageBox.Show("There was a problem registering the function: \n\"" + e.Message + "\"");
                throw;
            }


        }

        private static RegistryKey CreateSubKey(RegistryKey parentKey, string subKeyName)
        {
            Console.WriteLine($"Registering '{subKeyName}' to '{parentKey.Name}' ");
            return parentKey.CreateSubKey(subKeyName);
        }

        [ComUnregisterFunctionAttribute]
        public static void UnregisterFunction(Type t)
        {
            try
            {
                Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
                Microsoft.Win32.RegistryKey hkcu = Microsoft.Win32.Registry.CurrentUser;

                string keyname = "SOFTWARE\\SolidWorks\\Addins\\{" + t.GUID.ToString() + "}";
                hklm.DeleteSubKey(keyname);

                keyname = "Software\\SolidWorks\\AddInsStartup\\{" + t.GUID.ToString() + "}";
                hkcu.DeleteSubKey(keyname);
            }
            catch (System.NullReferenceException nl)
            {
                Console.WriteLine("There was a problem unregistering this dll: " + nl.Message);
                System.Windows.Forms.MessageBox.Show("There was a problem unregistering this dll: \n\"" + nl.Message + "\"");
            }
            catch (System.Exception e)
            {
                Console.WriteLine("There was a problem unregistering this dll: " + e.Message);
                System.Windows.Forms.MessageBox.Show("There was a problem unregistering this dll: \n\"" + e.Message + "\"");
            }
        }

        #endregion

        #region SolidWorks Connect DisConnect

        public bool ConnectToSW(object ThisSW, int cookie)
        {
            ConnectToSWPre();
            SwApp = (SldWorks)ThisSW;
            addinID = cookie;
            ActiveSolidWorks = this;

            //Setup callbacks
            SwApp.SetAddinCallbackInfo(0, this, addinID);

            #region Setup the Command Manager

            iCmdMgr = SwApp.GetCommandManager(cookie);

            ConnectToSWPost(SwApp);

            #endregion

            return true;
        }

        public bool DisconnectFromSW()
        {
            OnRemoveCommandMgr();

            Marshal.ReleaseComObject(iCmdMgr);
            iCmdMgr = null;
            Marshal.ReleaseComObject(SwApp);
            SwApp = null;
            //The addin _must_ call GC.Collect() here in order to retrieve all managed code pointers 
            GC.Collect();
            GC.WaitForPendingFinalizers();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DisConnectSWPost();
            return true;
        }

        #endregion

        #region abstract method

        public abstract void ConnectToSWPre();

        public abstract void ConnectToSWPost(SldWorks swApp);

        public abstract void OnRemoveCommandMgr();

        public abstract void DisConnectSWPost();

        #endregion

    }
}
