using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject shootPrefab;

    public Transform aim;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shoot();
        }
        
    }

    private void shoot()
    {
        GameObject bullet = Instantiate(shootPrefab, aim.position, transform.rotation);
    }
}
