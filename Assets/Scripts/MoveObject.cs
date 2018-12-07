using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    Rigidbody rigidbody;

    void Start()
    {
        // Store reference to attached Rigidbody
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen);

        Vector3 pos1 = Camera.main.ScreenToWorldPoint(pos);
        pos1.x = Mathf.Clamp(pos1.x, -3.36f, 4.2f);
        pos1.y = Mathf.Clamp(pos1.y, 0.2f, 2.7f);
        pos1.z = Mathf.Clamp(pos1.z, -6.3f, 2.8f);
        rigidbody.MovePosition(pos1);
    }



}
