using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Tip1.Services
{
    public class LocalServiceB : ILocalServiceB, IInitializable
    {
        private IGlobalService _globalService;

        [Inject]
        private void Construct(IGlobalService globalService)
        {
            Debug.Log("Constructing the local service B");
            
            _globalService = globalService;
        }
        
        public void Initialize()
        {
            Debug.Log("Initializing the local service B");
        }

        public void Interact()
        {
            Debug.Log("Interacting with the local service B");
            
            _globalService?.Interact();
        }
    }
}