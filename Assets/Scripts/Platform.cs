﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : screen
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (transform.position.x <= -10)
        {
            Remove();
        }
    }
    void Remove()
    {
        Destroy(this.gameObject);
    }
}
