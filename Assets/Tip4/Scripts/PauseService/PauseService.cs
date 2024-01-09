using System.Collections.Generic;
using System.Linq;
using VContainer;

namespace Tip4
{
    public class PauseService : IPauseService
    {
        private List<IPausable> _pausables;
        
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