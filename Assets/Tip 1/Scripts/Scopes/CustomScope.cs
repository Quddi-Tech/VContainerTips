using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Tip1.Scopes
{
    public abstract class CustomScope : LifetimeScope
    {
        [SerializeField] private List<MonoInstaller> _injectableServicesInstallers = new();
        [SerializeField] private List<MonoInstaller> _defaultServicesInstallers = new();

        [Inject]
        private void Construct(IObjectResolver objectResolver)
        {
            _injectableServicesInstallers.ForEach(objectResolver.Inject);
        }
        
        protected override void Configure(IContainerBuilder builder)
        {
            _injectableServicesInstallers.ForEach(service => service.Install(builder));
            _defaultServicesInstallers.ForEach(service => service.Install(builder));
        }
    }
}