using UnityEngine;
using VContainer;

namespace Tip3
{
    public class BaseE : MonoBehaviour
    {
        [Inject]
        public virtual void Construct()
        {
            Debug.Log("BaseE constructed");
        }
    }
}