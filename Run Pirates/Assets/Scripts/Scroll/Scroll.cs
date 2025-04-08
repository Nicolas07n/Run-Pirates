using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private float scrollSpeed = 8f;// Velocidad
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left *  scrollSpeed * Time.deltaTime); //Hace que en todo lo que se lo pongas se mueva hacia la left izquierda.
    }
}
