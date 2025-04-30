using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // aqui llamamos a game over
            GameOverManager gameOverManager = FindObjectOfType<GameOverManager>();
            if (gameOverManager != null)
            {
                gameOverManager.MostrarGameOver();
            }

            // Para el personaje no se nos mueva
            collision.gameObject.SetActive(false);
        }
    }
}