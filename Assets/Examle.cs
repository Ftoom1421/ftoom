using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examle : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        TextMesh texture = FindAnyObjectByType<TextMesh>();
        if (texture)
            Debug.Log("TextMesh object found: " + texture.name);
        else
            Debug.Log("No TextMesh object could be found");

        CanvasRenderer canvas = FindAnyObjectByType<CanvasRenderer>();
        if (canvas)
            Debug.Log("CanvasRenderer object found: " + canvas.name);
        else
            Debug.Log("No CanvasRenderer object could be found");
    }

}