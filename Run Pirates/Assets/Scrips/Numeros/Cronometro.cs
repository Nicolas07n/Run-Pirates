using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo; // Arrastra aqu� el TextMeshPro en el Inspector
    private float tiempo;

    void Update()
    {
        tiempo += Time.deltaTime; // Aumenta el tiempo cada frame
        textoTiempo.text = tiempo.ToString("F2"); // Muestra con 2 decimales
    }
}
