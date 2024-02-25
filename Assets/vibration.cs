using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class vibration : MonoBehaviour

{
    public float distanceFormCenter = 2.0f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float sinValue = Mathf.Sin(Time.time);
        float cosValue = Mathf.Cos(Time.time);
        transform.position = new Vector3(cosValue * distanceFormCenter, transform.position.y, sinValue * distanceFormCenter) + new Vector3(target.position.x, 0, target.position.z);
    }
}
