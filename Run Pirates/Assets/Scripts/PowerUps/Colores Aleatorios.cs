using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoresAleatorios : MonoBehaviour
{
    public float duration = 3f; // tiempo que quierp que dure

    private SpriteRenderer pirataRenderer;
    private Color colorOriginal;

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
            pirataRenderer = collision.GetComponent<SpriteRenderer>();

            if (pirataRenderer != null)
            {
                // Ocultar el power-up visualmente y físicamente
                powerUpRenderer.enabled = false;
                col.enabled = false;

                StartCoroutine(CambiarColorTemporal());
            }
        }
    }

    private IEnumerator CambiarColorTemporal()
    {
        colorOriginal = pirataRenderer.color;

        // Cambiar a un color aleatorio
        pirataRenderer.color = new Color(Random.value, Random.value, Random.value);

        yield return new WaitForSeconds(duration);

        // Volver al color original
        pirataRenderer.color = colorOriginal;

        // Destruir el power-up al finalizar
        Destroy(gameObject);
    }
}
