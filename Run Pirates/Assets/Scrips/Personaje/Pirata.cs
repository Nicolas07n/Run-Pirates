using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Pirata : MonoBehaviour
{
    private Rigidbody2D pirataRb;
    public Transform groundcheck; //La posiciendo de los pies del pirata
    public LayerMask ground; // La capa del suelo
    public float radius; //Radio del circulo , lo que hace es como crear un circulo pequeño en los pies que cada vez que toca el suelo detecta que es el suelo y puede saltar

    public float upForce = 5f;
    void Start()
    {
        pirataRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    { // El Overlap te crea el circulo invisible //posicion del punto  //el radio  //Y el layer
        bool isGrounded = Physics2D.OverlapCircle(groundcheck.position , radius  ,  ground);//Si el circulo con el radio hace contacto con el ground devuelve true y toca suelo

        if (Input.GetKeyDown(KeyCode.Space))// Salto 
        {
            if (isGrounded)//Si esta tocando el suelo hace el salto
            {
                pirataRb.AddForce(Vector2.up * upForce);
            }

            

        }
    }
}
