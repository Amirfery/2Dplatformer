using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int HP;
    public Vector3 speed;
    public Vector3 height;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        HP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed);
        }
    }
    void Jump()
    {
        if (Input.GetKey("space"))
        {
            rb.AddForce(height);
        }
    }
    void Damage()
    {
        HP -= 1;
        if (HP <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Lava":
                Die();
                break;
            case "Enemy":
                Damage();
                break;
        }
    }
}
