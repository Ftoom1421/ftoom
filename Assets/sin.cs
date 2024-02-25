using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class sin : MonoBehaviour
{

    public float speed;
    public float magniute;

    private void Update()
    {
        float cycle = Time.time / speed;
        transform.localScale = new Vector3(SineAmount(cycle), CoseAmount(cycle), SineAmount(cycle));
    }

    private float CoseAmount(float cycle)
    {
        return magniute * Mathf.Cos(Time.time * speed);
    }

    // Start is called before the first frame update
    public float SineAmount(float cycle)

    {
        return magniute * Mathf.Sin(Time.time * speed);

    }
}