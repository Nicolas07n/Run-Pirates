using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    // tambien nico usalo para llamrlo desde otros lados
    public void MostrarGameOver()
    {
        Time.timeScale = 0f; //Para parar el juego
        gameOverPanel.SetActive(true);
    }
}