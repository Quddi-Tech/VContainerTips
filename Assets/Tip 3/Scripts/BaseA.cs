using UnityEngine;
using VContainer;

namespace Tip3
{
    public class BaseA : MonoBehaviour
    {
        [Inject]
        protected void Construct()
        {
            Debug.Log("BaseA constructed");
        }
    }
}