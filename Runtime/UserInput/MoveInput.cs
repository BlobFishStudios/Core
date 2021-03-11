using UnityEngine;
using UnityEngine.Events;

namespace Core.UserInput
{
    public class MoveInput : MonoBehaviour
    {
        public UnityEvent onMoveInput;

        private void FixedUpdate()
        {
            CheckMoveInput();
        }

        private void CheckMoveInput()
        {
            if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                onMoveInput?.Invoke();
            }
        }
    }
}