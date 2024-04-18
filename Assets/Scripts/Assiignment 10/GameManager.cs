using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public int CurrentWeapon;
    public ScriptableWeapon[] Weapons;
    private void Awake()
    {
        Instance = this;
    }

}
