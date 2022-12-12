using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    int attack = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Hp hp = collision.gameObject.GetComponent<Hp>();

        if(hp != null)
        {
            hp.takeDamage(attack);
        }

        Destroy(gameObject);
    }
}
