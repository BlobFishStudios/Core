using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using Core.Move.Restrictions;

namespace Core.Move
{
    public abstract class AbstractMove : MonoBehaviour, IMoveable
    {
        [SerializeField] protected float speed;
        [SerializeField] public UnityEvent onMove;

        public float Speed { get { return speed; } }
        public Dictionary<string, bool> Restrictions { get; set; }
        public PositionRestriction positionRestriction;

        protected virtual void Awake()
        {
            Restrictions = new Dictionary<string, bool>();
            positionRestriction = new PositionRestriction();
        }

        public abstract void Move(Vector3 data);

        protected abstract Vector3 CreateNextPosition(Vector3 data);
    }
}