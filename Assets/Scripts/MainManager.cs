using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    //     public static MainManager Instance;
    //     public Color TeamColor; // new varible declared

    //     public void NewColorSelected(Color color)
    //     {
    //         MainManager.Instance.TeamColor = color;
    //     }
    //     private void start()
    //     {
    //         if (MainManager.Instance != null)
    //         {
    //             SetColor(MainManager.Instance.TeamColor);
    //         }
    //     }
    //     private void Awake()
    //    {
    //     // start of new code
    //     if( Instance != null)
    //     {
    //         Destroy (gameObject);
    //         return;
    //     }
    //     Instance = this;
    //     DontDestroyOnLoad(gameObject);
    //    } 
}
