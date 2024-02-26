using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class quaternions : MonoBehaviour
{
    public Transform target;
    private Quaternion current;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0, 0, 5 * Time.deltaTime);
    }

}

