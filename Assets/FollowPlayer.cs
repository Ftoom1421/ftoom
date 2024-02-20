using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Followplayer : MonoBehaviour
{

    // Start is called before the first frame update

    public Transform player;
    public Vector3 offest;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offest;
    }

}