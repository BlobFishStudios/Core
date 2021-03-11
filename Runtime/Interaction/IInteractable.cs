using UnityEngine;

namespace Core.Interaction
{
    public interface IInteractable
    {
        void Interact(GameObject interactor);
    }
}