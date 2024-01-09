using Tip1.Scopes;
using VContainer;
using VContainer.Unity;

namespace Tip4
{
    public class PauseServiceInstaller : MonoInstaller
    {
        public override void Install(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<PauseService>();
        }
    }
}