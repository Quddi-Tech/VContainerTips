using UnityEngine;
using VContainer;

namespace Tip3
{
    public class BaseC : MonoBehaviour
    {
        [Inject]
        private void Construct()
        {
            Debug.Log("BaseC constructed");
        }
    }
}