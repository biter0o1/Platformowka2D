using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb.velocity = new Vector2(-1f, 0f) * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -1f, 1f) * -1, 0f) * moveSpeed;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }


    // Update is called once per frame
    void Update()
    {
    }
}
