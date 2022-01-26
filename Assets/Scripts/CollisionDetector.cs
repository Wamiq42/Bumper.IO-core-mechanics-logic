using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject collided = null;
    public Texture[] texture;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < 0 && collided != null)
        {
            ChangingTexture();
            ChangingScaleandMass();
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.y < -2.2f)
            Destroy(gameObject);
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        { 
            collided = collision.gameObject;
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2, ForceMode.Impulse);
        }
        
    }


    //Changing the Textures
    void ChangingTexture()
    {
        //meshRenderer.material.EnableKeyword("_NORMALMAP");
        int randomTextIndex = Random.Range(0, texture.Length);
        MeshRenderer meshRenderer = collided.gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.SetTexture("_MainTex", texture[randomTextIndex]);
    }


    //Method Changes the Scale and Mass
    void ChangingScaleandMass()
    {
        collided.transform.localScale += transform.localScale;
        collided.gameObject.GetComponent<Rigidbody>().mass += 1;
    }
}
