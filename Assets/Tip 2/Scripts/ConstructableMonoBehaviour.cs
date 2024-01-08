using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Tip2
{
    public class ConstructableMonoBehaviour : MonoBehaviour
    {
        [SerializeField] private Button _createEmptyAButton;
        [SerializeField] private Button _createFilledAButton;
        
        private IObjectResolver _objectResolver;

        [Inject]
        private void Construct(IObjectResolver objectResolver)
        {
            _objectResolver = objectResolver;
            Debug.Log("Construct() from a ConstructableMonoBehaviour");
        }
        
        public void CreateEmptyAInstance()
        {
            var a = new ConstructableDefaultClassA();
            
            _objectResolver.Inject(a);
        }

        public void CreateFilledAInstance()
        {
            var b = new ConstructableDefaultClassB();

            var a = new ConstructableDefaultClassA(b);
            
            _objectResolver.Inject(a);
        }

        private void OnEnable()
        {
            _createEmptyAButton.onClick.AddListener(CreateEmptyAInstance);
            _createFilledAButton.onClick.AddListener(CreateFilledAInstance);
        }

        private void OnDisable()
        {
            _createEmptyAButton.onClick.RemoveListener(CreateEmptyAInstance);
            _createFilledAButton.onClick.RemoveListener(CreateFilledAInstance);
        }
    }
}