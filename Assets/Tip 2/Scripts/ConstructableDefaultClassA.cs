using UnityEngine;
using VContainer;

namespace Tip2
{
    public class ConstructableDefaultClassA
    {
        private readonly ConstructableDefaultClassB _constructableDefaultClassB;

        public ConstructableDefaultClassA() : this(null) { }

        public ConstructableDefaultClassA(ConstructableDefaultClassB constructableDefaultClassB)
        {
            _constructableDefaultClassB = constructableDefaultClassB;
        }
        
        [Inject]
        private void Construct(IObjectResolver objectResolver)
        {
            Debug.Log("Construct() from a ConstructableDefaultClassA");
            
            if (_constructableDefaultClassB != null)
                objectResolver.Inject(_constructableDefaultClassB);
        }
    }
}