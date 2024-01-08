using Tip1.Services;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Tip1.Tools
{
    public class GlobalServiceReceiver : MonoBehaviour
    {
        [SerializeField] private Button _interactButton;
        
        private IGlobalService _globalService;

        [Inject]
        private void Construct(IGlobalService globalService)
        {
            _globalService = globalService;
        }

        private void OnInteractButtonClickedHandler()
        {
            _globalService.Interact();
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