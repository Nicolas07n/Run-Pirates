using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoSalto : MonoBehaviour
{
    public float speedBoost = 3f; //Aumenta la velocidad
    public float duration = 1f; // Duración del efecto

    private Pirata pirataScript;
    private SpriteRenderer spriteRenderer;
    private Collider2D col;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pirataScript = collision.gameObject.GetComponent<Pirata>();

            if (pirataScript != null)
            {
                // Ocultar el objeto visualmente y desactivarlo físicamente
                spriteRenderer.enabled = false;
                col.enabled = false;

                StartCoroutine(AumentarVelocidad());
            }
        }
    }

    private IEnumerator AumentarVelocidad()
    {
        pirataScript.upForce += speedBoost; // Aumenta la fuerza del salto
             yield return new WaitForSeconds(duration); // Espera 3 segundos
        pirataScript.upForce -= speedBoost; // Vuelve a la velocidad normal
        Destroy(gameObject);//Lo destruye
    }
}

