using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP;
    public Vector3 speed;

    void Start()
    {
        HP = 1;
    }

    void Update()
    {
        Move();

        if(transform.position.x <= -10)
        {
            Die();
        }
    }
    void Move()
    {
        transform.position += speed * Time.deltaTime;
    }
    void Die()
    {
        Destroy(this.gameObject);
    }
    void Damage()
    {
        HP -= 1;
        if (HP <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Fire")
        {
            Damage();
        }
    }
}
