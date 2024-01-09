using UnityEngine;
using VContainer;

namespace Tip3
{
    public class DerivedC : BaseC
    {
        [Inject]
        private void Construct()
        {
            Debug.Log("DerivedC constructed");
        }
    }
}