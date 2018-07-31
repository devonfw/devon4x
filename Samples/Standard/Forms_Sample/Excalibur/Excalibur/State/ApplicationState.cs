using Excalibur.Configuration;
using Excalibur.Shared.State;

namespace Excalibur.State
{
    public class ApplicationState : BaseState<Config>, IApplicationState
    {
        public string Email
        {
            get { return Config.Email; }
            set { Config.Email = value; }
        }
    }
}
