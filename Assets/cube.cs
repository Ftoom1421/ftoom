using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class cube : MonoBehaviour
{

    private Rigidbody rb;

    public float forwardForce = -2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // We marked this as "Fixed"Update because we
    // are using it to mass with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0); // Add a force of 2000 on the z-axis 

        if (Input.GetKey(KeyCode.D))
        {
            // only executed if condition is met 
            rb.AddForce(0, sidewaysForce * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }

    }

}
