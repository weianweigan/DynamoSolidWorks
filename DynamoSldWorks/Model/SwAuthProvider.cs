using Greg;
using Greg.AuthProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DynamoSldWorks.Model
{
    [Obsolete]
    public class SwAuthProvider : IAuthProvider
    {
        private readonly SynchronizationContext SyncContext;

        public LoginState LoginState
        {
            get
            {
                bool result = false;
                SyncContext.Send((_) => result = true, null);
                return result ? LoginState.LoggedIn : LoginState.LoggedOut;
            }
        }

        public string Username => "";

        public event Func<object, bool> RequestLogin;
        public event Action<LoginState> LoginStateChanged;

        public bool Login()
        {
            bool result = false;

            SyncContext.Send((_) => result = true, null);
            LoginStateChanged?.Invoke(result ? LoginState.LoggedIn : LoginState.LoggedOut);

            return true;
        }

        public void Logout()
        {
        }

        public void SignRequest(ref global::RestSharp.RestRequest m, global::RestSharp.RestClient client)
        {

        }
    }
}
