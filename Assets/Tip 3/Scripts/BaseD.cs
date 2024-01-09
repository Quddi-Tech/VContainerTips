using UnityEngine;
using VContainer;

namespace Tip3
{
    public class BaseD : MonoBehaviour
    {
        [Inject]
        public void Construct()
        {
            Debug.Log("BaseD constructed");
        }
    }
}