using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRpeat : MonoBehaviour
{
    private float spriteWidht;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();//Como conseguir el ancho del sprite
        spriteWidht = groundCollider.size.x; //En el sprite widht le añado el ancho del colider , que tiene que ser el mismo que el sprite
    }

    // Update is called once per frame
    void Update()
    {// Al estar yendo a la izquierda la cordenada (transform.position.x) esta siendo mas negativa , en el momento que sea negativo a pasado el ancho 
        if (transform.position.x < -spriteWidht)//Si (transform.position.X) ob
        {
            transform.Translate(Vector2.right * 2f * spriteWidht);//Y la reposicionamos , haciendo que ahora se mueva a la derecha dos veces (2f) el ancho del cuadrado y sprite

        }
    }
}
