using UnityEngine;
using UnityEngine.Events;

namespace Core.Move
{
    public abstract class AbstractMove : MonoBehaviour, IMoveable
    {
        [SerializeField] public UnityEvent onMove;

        public abstract void Move(Vector3 inputs);
    }
}