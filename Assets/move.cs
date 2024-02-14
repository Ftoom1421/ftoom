using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec2 =new Vector3(1,2,3);

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        transform.position += Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
        transform.position += Vector3.back;

        if (Input.GetKey(KeyCode.RightArrow))
        transform.position += Vector3.right;

        if (Input.GetKey(KeyCode.LeftArrow))
        transform.position += Vector3.left;
    }
}

