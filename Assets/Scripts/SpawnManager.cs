using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;

    public int numberOfEnemies;
    private float posX = 6;
    private float posZ = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(numberOfEnemies);
    }

    void SpawnEnemies(int number)
    {
        for(int i = 1; i <= number;i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-posX, posX), 1.2f, Random.Range(-posZ, posZ));
            Instantiate(enemy, randomPosition, enemy.transform.rotation);
        }
        
    }

}

    
