using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    [Header("Control the speed of the cube")]
    public float Speed;


    public Vector3 movementDirection;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime * Speed, Space.World);
    }
}
