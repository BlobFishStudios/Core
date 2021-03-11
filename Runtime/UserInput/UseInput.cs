using UnityEngine;
using UnityEngine.Events;

namespace Core.UserInput
{
    public class UseInput : MonoBehaviour
    {
        public UnityEvent onUseInput;

        private void Update()
        {
            CheckUseInput();
        }

        private void CheckUseInput()
        {
            if(Input.GetMouseButtonDown(0))
            {
                onUseInput?.Invoke();
            }
        }
    }
}