using UnityEngine;
using VContainer;

namespace Tip3
{
    public class DerivedE : BaseE
    {
        [Inject]
        public override void Construct()
        {
            Debug.Log("DerivedE constructed");
        }
    }
}