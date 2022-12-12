using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Apple : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().addPoint();
            Destroy(gameObject);
        }
    }
}
