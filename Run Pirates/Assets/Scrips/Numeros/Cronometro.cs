using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo; // Arrastra aquí el TextMeshPro en el Inspector
    public float velocidad = 5f;
    private float tiempo;
    

    void Update()
    {
        tiempo += Time.deltaTime * velocidad; // Aumenta el tiempo cada frame y al multiplicarlo por velocidad sube su velocidad
        textoTiempo.text = Mathf.FloorToInt(tiempo).ToString(); // Muestra los numeros enteros
    }
}
