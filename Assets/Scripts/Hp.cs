using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

    public TMP_Text text;
    public int maxHp = 3;
    int hp;
    void Start()
    {
        hp = maxHp;
        //text = GetComponent<Text>();
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            if (CompareTag("Player"))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wrog"))
        {
            hp--;
            UpdateText();
        }
    }

    public void takeDamage(int damage)
    {
        UpdateText();
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void UpdateText()
    {
        
        if (text != null)
        {
            text.text = "¯ycie: " + hp;
        }
    }
}
