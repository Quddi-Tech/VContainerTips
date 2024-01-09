using Tip1.Scopes;
using VContainer;
using VContainer.Unity;

namespace Tip4
{
    public class InputServiceInstaller : MonoInstaller
    {
        public override void Install(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<InputService>();
        }
    }
}