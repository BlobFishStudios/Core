using System.Collections.Generic;
using UnityEngine;

namespace Core.Interaction
{
    public class Interactor : MonoBehaviour
    {
        public IInteractable CurrentInteractable { get; set; }
        public List<IInteractable> Interactables { get; private set; }

        private void Start()
        {
            CurrentInteractable = null;
            Interactables = new List<IInteractable>();
        }

        public void Interact()
        {
            if(CurrentInteractable == null)
            {
                if(Interactables.Count > 0)
                {
                    Interactables[0].Interact(gameObject);
                }
            }
            else
            {
                CurrentInteractable.Interact(gameObject);
            }
        }
    }
}