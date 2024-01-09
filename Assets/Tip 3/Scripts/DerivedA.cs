using UnityEngine;
using VContainer;

namespace Tip3
{
    public class DerivedA : BaseA
    {
        [Inject]
        protected new void Construct()
        {
            Debug.Log("DerivedA constructed");
        }
    }
}