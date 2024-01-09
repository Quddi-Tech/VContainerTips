using System;
using Unity.VisualScripting;

namespace Tip4
{
    public interface IInputService
    {
        event Action<MovementDirection> InputEvent;
    }
}