using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MoveCamera : MonoBehaviour
{
    private static readonly float MoveSpeed = 0.7f;

    //set the boundaries of Moving the camera
    private static readonly float[] BoundsX = new float[] { -4f, 2.4f };
    private static readonly float[] BoundsZ = new float[] { -6f, 2.5f };

     public void Right()
     {
            // Determine how much to move the camera
            Vector3 move = new Vector3(MoveSpeed, 0.0f, 0.0f);

            // Perform the movement
            transform.Translate(move,Space.World);

            // Ensure the camera remains within bounds.
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x, BoundsX[0], BoundsX[1]);
            pos.z = Mathf.Clamp(transform.position.z, BoundsZ[0], BoundsZ[1]);
            transform.position = pos;
     }

    public void Left()
    {
        Vector3 move = new Vector3(-MoveSpeed, 0.0f, 0.0f);
        transform.Translate(move,Space.World);
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, BoundsX[0], BoundsX[1]);
        pos.z = Mathf.Clamp(transform.position.z, BoundsZ[0], BoundsZ[1]);
        transform.position = pos;
    }

    public void Forward()
    {
        Vector3 move = new Vector3(0.0f, 0.0f, MoveSpeed);
        transform.Translate(move,Space.World);
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, BoundsX[0], BoundsX[1]);
        pos.z = Mathf.Clamp(transform.position.z, BoundsZ[0], BoundsZ[1]);
        transform.position = pos;
    }

    public void Backward()
    {
        Vector3 move = new Vector3(0.0f, 0.0f, -MoveSpeed);
        transform.Translate(move,Space.World);
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, BoundsX[0], BoundsX[1]);
        pos.z = Mathf.Clamp(transform.position.z, BoundsZ[0], BoundsZ[1]);
        transform.position = pos;
    }
}