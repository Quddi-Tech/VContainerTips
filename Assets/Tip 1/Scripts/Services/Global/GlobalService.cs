using Unity.VisualScripting;
using UnityEngine;

namespace Tip1.Services
{
    public class GlobalService : IGlobalService, IInitializable
    {
        public void Initialize()
        {
            Debug.Log("Initializing the global service");
        }

        public void Interact()
        {
            Debug.Log("Interacting with the global service");
        }
    }
}