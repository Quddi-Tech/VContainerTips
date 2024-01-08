using UnityEngine;

namespace Tip1.Scopes
{
    public class GameScope : CustomScope
    {
        private void OnValidate()
        {
            if (autoRun == true)
                Debug.LogWarning($"The game scope is built in the {nameof(Bootstrap)}");
            
            autoRun = false;
        }
    }
}