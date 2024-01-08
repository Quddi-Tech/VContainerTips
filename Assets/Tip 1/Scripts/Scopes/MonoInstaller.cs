using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Tip1.Scopes
{
    public abstract class MonoInstaller : MonoBehaviour, IInstaller
    {
        public abstract void Install(IContainerBuilder builder);
    }
}