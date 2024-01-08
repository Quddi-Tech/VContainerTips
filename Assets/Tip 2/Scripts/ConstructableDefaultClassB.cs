using UnityEngine;
using VContainer;

namespace Tip2
{
    public class ConstructableDefaultClassB
    {
        [Inject]
        private void Construct()
        {
            Debug.Log("Construct() from a ConstructableDefaultClassB");
        }
    }
}