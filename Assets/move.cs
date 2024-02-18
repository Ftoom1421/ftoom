using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
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

