using Tip1.Services;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Tip1.Tools
{
    public class LocalServiceAReceiver : MonoBehaviour
    {
        [SerializeField] private Button _interactButton;
        
        private ILocalServiceA _localServiceA;

        [Inject]
        private void Construct(ILocalServiceA localServiceA)
        {
            _localServiceA = localServiceA;
        }

        private void OnInteractButtonClickedHandler()
        {
            _localServiceA.Interact();
        }
        
        private void OnEnable()
        {
            _interactButton.onClick.AddListener(OnInteractButtonClickedHandler);
        }

        private void OnDisable()
        {
            _interactButton.onClick.RemoveListener(OnInteractButtonClickedHandler);
        }
    }
}