using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public TMP_Text points;
    int pointsAmount = 0;
    void Start()
    {
        updateText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("p2d");
        } else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if(pointsAmount == 20)
        {
            SceneManager.LoadScene("Zwyciestwo");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    public void test()
    {
        Debug.Log("abc");
    }

    public void addPoint()
    {
        pointsAmount++;
        updateText();
    }

    private void updateText()
    {
        if (points != null)
        {
            points.text = "Punkty: " + pointsAmount;
        }
    }

}
