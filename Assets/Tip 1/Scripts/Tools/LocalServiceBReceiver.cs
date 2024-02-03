using Tip1.Services;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Tip1.Tools
{
    public class LocalServiceBReceiver : MonoBehaviour
    {
        [SerializeField] private Button _interactButton;
        
        private ILocalServiceB _localServiceB;

        [Inject]
        private void Construct(ILocalServiceB localServiceB)
        {
            _localServiceB = localServiceB;
        }

        private void OnInteractButtonClickedHandler()
        {
            _localServiceB.Interact();
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