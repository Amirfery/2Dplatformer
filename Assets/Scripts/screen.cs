using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour
{
    public Vector3 speed;
    public void Move()
    {
        transform.position += speed * Time.deltaTime;
    }
}
