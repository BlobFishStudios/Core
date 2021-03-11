using UnityEngine;

namespace Core
{
    public class AbstractEventSubscriber <T> : MonoBehaviour
    {
        protected T item;

        protected virtual void Awake()
        {
            item = GetComponent<T>();
        }
    }
}