using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRigidBody;
    

    public float speed;
    private float horizontalInput;
    private float verticalInput;

    public bool lastcollided = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        PlayerRigidBody.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime);
        PlayerRigidBody.AddForce(Vector3.right * horizontalInput * speed * Time.deltaTime);


    }

   

}
