using UnityEngine;
using VContainer;

namespace Tip2
{
    public class MonoBehaviourInjector : MonoBehaviour
    {
        [SerializeField] private ConstructableMonoBehaviour _constructableMonoBehaviour;
        
        [Inject]
        private void Construct(IObjectResolver objectResolver)
        {
            objectResolver.Inject(_constructableMonoBehaviour);
        }
    }
}