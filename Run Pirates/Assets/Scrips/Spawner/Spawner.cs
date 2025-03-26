using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles ;
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            float tiempomin = 0.6f;
            float tiempomax = 1.8f;
            float randomTime = Random.Range(tiempomin,tiempomax);
            Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }


}
