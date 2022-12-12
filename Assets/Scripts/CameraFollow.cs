using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);
        transform.position = pos;
    }
}
