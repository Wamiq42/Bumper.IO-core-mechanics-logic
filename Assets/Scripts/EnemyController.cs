using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject player;
    //private GameObject enemy;
    public Rigidbody enemyRigidbody;
   

    private Vector3 targetPosition;
    private float speed = 1;
    private string nameofEnemies;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        

    }

    // Update is called once per frame
    void Update()
    {

        
        if (player != null)
        {
            targetPosition = (player.transform.position - transform.position).normalized;
            
            enemyRigidbody.AddForce(targetPosition * speed);
         
        }
        
    }

    
}
