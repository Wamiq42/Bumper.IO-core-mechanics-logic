using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    //public int numberofEnemies;
    private Vector3 minimumDistance = new Vector3(1f, 1f, 1f);
    private Vector3 distance;
    public float cameraSize;

    // Start is called before the first frame update
    void Start()
    {
        //numberofEnemies = GameObject.Find("SpawnManager").GetComponent<SpawnManager>().numberOfEnemies;

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && enemy != null)
        {
            distance = enemy.transform.position - player.transform.position;
            cameraSize = Camera.main.orthographicSize;

            if ((distance.x < 1f && distance.x > -1f) || (distance.z < 1f && distance.z > -1f) && cameraSize > 4f && cameraSize < 8.0f)
            {
                Camera.main.orthographicSize -= 0.2f * Time.deltaTime;
            }
            else if((distance.x > 1f) || (distance.z > 1f)&&cameraSize < 4f)
            {
                Camera.main.orthographicSize += 0.2f * Time.deltaTime;
            }



        }
        



    }




}
