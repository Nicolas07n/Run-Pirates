using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo; // Arrastra aquí el TextMeshPro en el Inspector
    public float velocidad = 7f;
    private int tiempo;
    

    void Update()
    {
        tiempo = Mathf.FloorToInt(Time.time * velocidad); // Aumenta el tiempo cada frame y al multiplicarlo por velocidad sube su velocidad
        textoTiempo.text = tiempo.ToString("D6"); // Muestra los numeros enteros
    }
}
