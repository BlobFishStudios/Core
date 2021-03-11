using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

namespace Core.Aim
{
    public abstract class AbstractAim : MonoBehaviour, IAimable
    {
        [SerializeField] public UnityEvent onAim;

        public Dictionary<string, bool> Restrictions { get; set; }

        protected virtual void Awake()
        {
            Restrictions = new Dictionary<string, bool>();
        }

        public abstract void Aim(Vector3 data);
    }
}