using UnityEngine;
using UnityEngine.Events;

namespace Core.Aim
{
    public abstract class AbstractAim : MonoBehaviour, IAimable
    {
        [SerializeField] public UnityEvent onAim;

        public abstract void Aim(Vector3 inputs);
    }
}