using UnityEngine;
using UnityEngine.Events;

namespace Core.UserInput
{
    public class MoveInput : MonoBehaviour
    {
        public UnityEvent<Vector3> onMoveInput;

        private void FixedUpdate()
        {
            CheckMoveInput();
        }

        private void CheckMoveInput()
        {
            if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                Vector3 inputs = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
                onMoveInput?.Invoke(inputs);
            }
        }
    }
}