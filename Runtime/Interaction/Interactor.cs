using System.Collections.Generic;
using UnityEngine;

namespace Core.Interaction
{
    public class Interactor : MonoBehaviour
    {
        public IInteractable Interactable { get; set; }
        public List<IInteractable> Interactables { get; private set; }

        private void Start()
        {
            Interactable = null;
            Interactables = new List<IInteractable>();
        }

        public void Interact()
        {
            if(Interactable == null)
            {
                if(Interactables.Count > 0)
                {
                    Interactables[0].Interact(gameObject);
                }
            }
            else
            {
                Interactable.Interact(gameObject);
            }
        }
    }
}