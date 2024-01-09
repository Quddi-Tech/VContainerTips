using System;
using UnityEngine;
using VContainer.Unity;

namespace Tip4
{
    public class InputService : IInputService, ITickable, IPausable
    {
        private bool _paused = false;
        
        public event Action<MovementDirection> InputEvent;

        public void Tick()
        {
            if (_paused)
                return;
            
            if (Input.GetKey(KeyCode.W))
            {
                InputEvent?.Invoke(MovementDirection.Up);
                Debug.Log("Up");
            }

            if (Input.GetKey(KeyCode.S))
            {
                InputEvent?.Invoke(MovementDirection.Down);
                Debug.Log("Down");
            }

            if (Input.GetKey(KeyCode.D))
            {
                InputEvent?.Invoke(MovementDirection.Right);
                Debug.Log("Right");
            }

            if (Input.GetKey(KeyCode.A))
            {
                InputEvent?.Invoke(MovementDirection.Left);
                Debug.Log("Left");
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