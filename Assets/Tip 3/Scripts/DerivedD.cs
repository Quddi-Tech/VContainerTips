using UnityEngine;
using VContainer;

namespace Tip3
{
    public class DerivedD : BaseD
    {
        [Inject]
        public new void Construct()
        {
            Debug.Log("DerivedD constructed");
        }
    }
}