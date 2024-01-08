using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tip1.Scopes
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameScope _gameScope;
        [SerializeField] private string _firstSceneName;

        private void Start()
        {
            _gameScope.Build();

            SceneManager.LoadScene(_firstSceneName);
        }
    }
}