using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeCollison : MonoBehaviour
{
    private void OnCollisionEnter(Collision objectHit)
    {
        if (objectHit.gameObject.CompareTag("Player"))
        {
            Debug.Log(" Player Hit");
        }
    }

    private void OnTriggerEnter(Collider other);
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.StartupLog("Player won");
        }
    }

}

