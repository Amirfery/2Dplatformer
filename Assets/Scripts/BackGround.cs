﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : screen
{
    void Start()
    {

    }
    void Update()
    {
        Move();

        if (transform.position.x <= -20)
        {
            Remove();
        }
    }
    void Remove()
    {
        Destroy(this.gameObject);
    }
}
