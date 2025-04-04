using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoVelocidad : MonoBehaviour
{
    public float speedBoost = 3f; // Cuánto aumenta la velocidad
    public float duration = 3f; // Duración del efecto

    private Pirata pirataScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pirataScript = collision.gameObject.GetComponent<Pirata>();

            if (pirataScript != null)
            {
                StartCoroutine(AumentarVelocidad());
            }

            Destroy(gameObject); // Elimina el power-up después de tocarlo
        }
    }

    private IEnumerator AumentarVelocidad()
    {
        pirataScript.upForce += speedBoost; // Aumenta la fuerza del salto
        yield return new WaitForSeconds(duration); // Espera 3 segundos
        pirataScript.upForce -= speedBoost; // Vuelve a la velocidad normal
    }
}

