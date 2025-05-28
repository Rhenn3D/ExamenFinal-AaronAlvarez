using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 offset;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    public GameObject followedCharacter;
    public Vector3 desiredPosition;

    void FixedUpdate()
    {
        if(followedCharacter == null)
        {
            return;
        }

        else
        {
        offset.z = -10;
        desiredPosition = followedCharacter.transform.position + offset;
        float ClampX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
        float ClampY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);
        Vector3 clampedPosition = new Vector3(ClampX, ClampY, desiredPosition.z);
        gameObject.transform.position = clampedPosition;
        }
    }
}
