using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Tip1.Tools
{
    public class SceneChanger : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private string _sceneName;

        private void OnClickedHandler()
        {
            SceneManager.LoadScene(_sceneName);
        }
        
        private void OnEnable()
        {
            _button.onClick.AddListener(OnClickedHandler);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClickedHandler);
        }
    }
}