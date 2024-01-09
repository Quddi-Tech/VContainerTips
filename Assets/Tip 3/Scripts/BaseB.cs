using UnityEngine;
using VContainer;

namespace Tip3
{
    public class BaseB : MonoBehaviour
    {
        [Inject]
        protected virtual void Construct()
        {
            Debug.Log("BaseB constructed");
        }
    }
}