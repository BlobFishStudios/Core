using UnityEngine;
using UnityEngine.Events;

namespace Core.UserInput
{
    public class AimInput : MonoBehaviour
    {
        public UnityEvent onAimInput;

        private void Update()
        {
            CheckAimInput();
        }

        private void CheckAimInput()
        {
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                onAimInput?.Invoke();
            }
        }
    }
}
