using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    public float Speed = 3;

     private void Update()
    {
       transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
