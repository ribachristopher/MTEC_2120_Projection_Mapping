using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatUp : MonoBehaviour
{
    float speed = 2;
    void Start()
    {

    }

    void Update()
    {
        MoveUp();
       
    }

    void MoveUp()
    {
        transform.position += Vector3.up * Time.deltaTime * speed;
        transform.Rotate(0, 5, 0 * Time.deltaTime);
    }
}