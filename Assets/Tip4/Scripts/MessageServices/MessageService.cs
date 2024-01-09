using UnityEngine;
using VContainer.Unity;

namespace Tip4
{
    public class MessageService : ITickable, IPausable
    {
        private bool _paused = false;
        private int _passedFrames = 0;

        private const int FramesDelay = 5;
        
        public void Tick()
        {
            if (_paused)
                return;
            
            _passedFrames++;

            if (_passedFrames >= 5)
            {
                Debug.Log("Some message");
                _passedFrames = 0;
            }
        }

        public void SetPaused()
        {
            _paused = true;
        }

        public void SetUnpaused()
        {
            _paused = false;
        }
    }
}