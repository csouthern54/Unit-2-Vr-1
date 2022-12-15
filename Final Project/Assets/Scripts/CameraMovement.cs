using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform targets;
    public Vector3 offset;

    void Update()
    {
        transform.position = targets.position + offset;
    }
}