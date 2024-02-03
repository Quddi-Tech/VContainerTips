using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tip1.Scopes
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private string _firstSceneName;

        private void Start()
        {
            SceneManager.LoadScene(_firstSceneName);
        }
    }
}