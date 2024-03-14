using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    private Rigidbody rb;





    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity += Vector3.forward;
    }
    void OnCollisionEnter(Collision collision)
    {


        switch (collision.gameObject.tag)
        {
            case "Player":
                Destroy(collision.gameObject);
                break;
            case "enemy":
                Destroy(collision.gameObject);
                break;
            default:
                Destroy(gameObject);
                break;

        }


        //Destroy(collision.gameObject.tag);
        // if (collision.gameObject.tag == "enemy")
        // {
        // Destroy(collision.gameObject);

        //if 


    }


}
