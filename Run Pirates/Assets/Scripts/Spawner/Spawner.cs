using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles ;//Aqui ponemos los diferentes prefabs
    public float tiempomin, tiempomax;
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnObstacle()//Corrutina
    {
        while (true)//bucle
        {
            int randomIndex = Random.Range(0, obstacles.Length);//Te devuelve un numero aleatorio entre 0 y la cantidad de obstaculos 
            float randomTime = Random.Range(tiempomin,tiempomax);//Genera un numero aleatorio tambien entre el timpo min y el max
            yield return new WaitForSeconds(randomTime);//Para que no puto pete el unity , osea no instancia todo de seguido
            Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);//Esto instancia al objeto
        }

        
    }



}
