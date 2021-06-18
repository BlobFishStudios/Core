using UnityEngine;
using UnityEngine.Events;

namespace Core.UserInput
{
    public class AimInput : MonoBehaviour
    {
        public UnityEvent<Vector3> onAimInput;

        private void Update()
        {
            CheckAimInput();
        }

        private void CheckAimInput()
        {
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                onAimInput?.Invoke(mousePosition);
            }
        }
    }
}
