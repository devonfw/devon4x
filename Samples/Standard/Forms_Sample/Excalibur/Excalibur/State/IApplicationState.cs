using Excalibur.Shared.State;

namespace Excalibur.State
{
    public interface IApplicationState : IBaseState
    {
        string Email { get; set; }
    }
}
