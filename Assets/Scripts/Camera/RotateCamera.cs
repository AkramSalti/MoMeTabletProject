using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour
{
    // Speed of camera rotation
    private float turnSpeed = 10f;      

    public void RightRotate()
    {

        transform.Rotate(new Vector3(0, turnSpeed, 0));
    }

    public void LeftRotate()
    {
        transform.Rotate(new Vector3(0, -turnSpeed, 0));
    }

    public void UpRotate()
    {
        transform.Rotate(new Vector3(-turnSpeed, 0, 0));
    }

    public void DownRotate()
    {

        
       transform.Rotate(new Vector3(turnSpeed, 0, 0));
    }

    public void ResetRotate()
    {
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}