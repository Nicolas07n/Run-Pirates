using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RalentizarJuego : MonoBehaviour
{
    public float slowFactor = 0.5f; // Velocidad del juego durante el efecto (0.5 = mitad de velocidad)
    public float duration = 3f;     // Duración del efecto en segundos reales

    private SpriteRenderer powerUpRenderer;
    private Collider2D col;

    private void Start()
    {
        powerUpRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Oculta el power-up visual y colisión
            powerUpRenderer.enabled = false;
            col.enabled = false;

            StartCoroutine(Ralentizar());
        }
    }

    private IEnumerator Ralentizar()
    {
        Time.timeScale = slowFactor;

        // Espera con tiempo real, no afectado por timeScale
        yield return new WaitForSecondsRealtime(duration);

        Time.timeScale = 1f; // Vuelve a la velocidad normal

        Destroy(gameObject);
    }
}
