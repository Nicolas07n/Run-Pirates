using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPowerUps : MonoBehaviour
{
    public GameObject[] obstacles;//Aqui ponemos los diferentes prefabs
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator SpawnObstacle()//Corrutina
    {
        while (true)//bucle
        {
            int randomIndex = Random.Range(0, obstacles.Length);//Te devuelve un numero aleatorio entre 0 y la cantidad de obstaculos 
            float tiempomin = 0.6f; //El tiempo minimo 
            float tiempomax = 1.8f;//El tiempo max
            float randomTime = Random.Range(tiempomin, tiempomax);//Genera un numero aleatorio tambien entre el timpo min y el max
            Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);//Esto instancia al objeto
            yield return new WaitForSeconds(randomTime);//Para que no puto pete el unity , osea no instancia todo de seguido
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject); // Para cuando toque El colider se destruya
    }
}
