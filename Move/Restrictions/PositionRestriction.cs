using System.Collections.Generic;
using UnityEngine;

namespace Core.Move.Restrictions
{
    public class PositionRestriction
    {
        public List<GameObject> Colliders { get; private set; }

        public PositionRestriction()
        {
            Colliders = new List<GameObject>();
        }

        public bool LegalPosition(Vector3 position)
        {
            foreach(GameObject collider in Colliders)
            {
                Vector3 colliderPosition = collider.transform.parent.localPosition;

                Vector3 colliderExtents = collider.transform.parent.localEulerAngles.z == 90 ? new Vector3(10.5f, 1) : new Vector3(1, 10.5f);

                Vector2 xBounds = new Vector2(colliderPosition.x - colliderExtents.x, 
                    colliderPosition.x + colliderExtents.x);
                Vector2 yBounds = new Vector2(colliderPosition.y - colliderExtents.y, 
                    colliderPosition.y + colliderExtents.y);

                bool legalX = true;
                bool legalY = true;

                xBounds.x = Mathf.Round(xBounds.x * 10f) / 10f;
                xBounds.y = Mathf.Round(xBounds.y * 10f) / 10f;
                yBounds.x = Mathf.Round(yBounds.x * 10f) / 10f;
                yBounds.y = Mathf.Round(yBounds.y * 10f) / 10f;

                if(position.x > xBounds.x && position.x < xBounds.y)
                {
                    legalX = false;
                }

                if(position.y > yBounds.x && position.y < yBounds.y)
                {
                    legalY = false;
                }

                if(legalX == false && legalY == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}