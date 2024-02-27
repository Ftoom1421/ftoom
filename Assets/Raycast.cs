using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    Ray ray;
    float maxDistance = 100;

    RaycastHit hit;
    // Start is called before the first frame update


    void CheckForColliders()
    {
        if (Physics.Raycast(ray, out hit, maxDistance)) // بغير layertohit  لارقام تسعه اكبر من واحدة, وحذفت الببلك حقت الليرماسك
        {
            Debug.Log(hit.collider.gameObject.name + "something was hit!");
        }
    }

    // Update is called once per frame
    void Update()
    {

        ray = new Ray(transform.position, transform.forward); //اقدر اقول رايت او فوروارد
        CheckForColliders();

    }
}
