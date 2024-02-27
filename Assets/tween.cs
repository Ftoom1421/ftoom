using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class tween : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        transform.DOScaleX(20, 1).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
