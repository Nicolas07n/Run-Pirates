using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Pirata : MonoBehaviour
{
    private Rigidbody2D pirataRb;
    public float upForce = 5f;
    void Start()
    {
        pirataRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pirataRb.AddForce(Vector2.up * upForce);

        }
    }
}
