using UnityEngine;
using VContainer;

namespace Tip3
{
    public class DerivedB : BaseB
    {
        [Inject]
        protected override void Construct()
        {
            Debug.Log("DerivedB constructed");
        }
    }
}