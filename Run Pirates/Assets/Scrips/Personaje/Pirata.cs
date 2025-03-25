using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirata : MonoBehaviour
{
    private Rigidbody2D pirataRb;
    void Start()
    {
        pirataRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {


        }
    }
}
