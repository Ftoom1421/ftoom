using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "WeaponObject", menuName = "WeaponScriptable")]
public class ScriptableWeapon : ScriptableObject
{
    // Start is called before the first frame update

    // حطيت int عشان هم ارقام الاثنين ذولي 
    public int Level, Poewr;

    // وهنا احط سترنق عشان هو اسم والمعلومات اسم 
    public string Name;

    public Sprite Icon;
}
