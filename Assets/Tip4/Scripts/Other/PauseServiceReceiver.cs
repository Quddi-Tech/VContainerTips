using System;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Tip4
{
    public class PauseServiceReceiver : MonoBehaviour
    {
        [SerializeField] private Button _pauseButton;
        [SerializeField] private Button _unpauseButton;
        
        private IPauseService _pauseService;

        [Inject]
        private void Construct(IPauseService pauseService)
        {
            _pauseService = pauseService;
        }
        
        private void OnPauseButtonClickedHandler()
        {
            _pauseService.Pause();    
        }
        
        private void OnUnpauseButtonClickedHandler()
        {
            _pauseService.Unpause();    
        }
        
        private void OnEnable()
        {
            _pauseButton.onClick.AddListener(OnPauseButtonClickedHandler);
            _unpauseButton.onClick.AddListener(OnUnpauseButtonClickedHandler);
        }

        private void OnDisable()
        {
            _pauseButton.onClick.RemoveListener(OnPauseButtonClickedHandler);
            _unpauseButton.onClick.RemoveListener(OnUnpauseButtonClickedHandler);
        }
    }
}