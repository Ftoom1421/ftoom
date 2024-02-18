using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class spherescriipt : MonoBehaviour
{

    [SerializeField] public GameObject shpere;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnShpere();
            InvokeRepeating("SpawnShpere", 0.0f, 1.0f);
        }
    }

    void SpawnShpere()
    {
        Instantiate(shpere);
    }
}
