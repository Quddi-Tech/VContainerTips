using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using VContainer;

namespace Tip4
{
    public class PauseService : IPauseService
    {
        private List<IPausable> _pausables;

        public event Action OnPause;
        public event Action OnUnPause;
        
        [Inject]
        private void Construct(IEnumerable<IPausable> pausables)
        {
            _pausables = pausables.ToList();
        }
        
        public void Pause()
        {
            _pausables?.ForEach(pausable => pausable.SetPaused());
        }

        public void Unpause()
        {
            _pausables?.ForEach(pausable => pausable.SetUnpaused());
        }
    }
}