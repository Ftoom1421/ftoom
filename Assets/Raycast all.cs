using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastall : MonoBehaviour
{
    Ray ray;
    RaycastHit[] hits;
    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray(transform.position, transform.forward);
        CheckForColliders();
    }

    void CheckForColliders()
    {

        hits = Physics.RaycastAll(ray);

        if (hits.Length > 0)
        {
            //  Array.Sort(hits, (RaycastHit x , Raycast y) => x.distance.CompareTo(y.distance));
            for (int i = 0; i < hits.Length; i++)
            {
                Debug.Log(hits[i].collider.gameObject.name);
            }
        }

    }
}