using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float speed = 0.005f;
    public Vector3 direction = Vector3.back;
    public bool isRunning = true;

    void Update()
    {
        if (!isRunning) return;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
