using System.Collections;
using System.Collections.Generic;
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
        Destroy(gameObject);

        //Destroy(collision.gameObject.tag);
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }


    }


}
