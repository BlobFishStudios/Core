using UnityEngine;
using UnityEngine.Events;

namespace Core.UserInput
{
    public class InteractInput : MonoBehaviour
    {
        public UnityEvent onInteractInput;

        private void Update()
        {
            CheckInteractInput();
        }

        private void CheckInteractInput()
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                onInteractInput?.Invoke();
            }
        }
    }
}