using Tip1.Scopes;
using VContainer;
using VContainer.Unity;

namespace Tip1.Services
{
    public class LocalServiceAInstaller : MonoInstaller
    {
        public override void Install(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<LocalServiceA>();
        }
    }
}