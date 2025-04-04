using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    
    public string playerTag = "Player"; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si el objeto que colisiona tiene el tag del pirata
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Destruye el PowerUp 
            Destroy(gameObject);
        }
    }
}       

   




