using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Image = Microsoft.Unity.VisualStudio.Editor.Image;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Icon;
    public TextMeshProUGUI Name, Level, power;
    public Button Prev, Next;
    public void NextWepaon()
    {

    }
    public void PrevWeapon()
    {

    }
    void FillWeapon()
    {
        Icon.sprite = GameManager.instance.Weapons[GameManager.instance.CurrentWeapon].Icon;
        Name.text = GameManager.instance.Weapons[GameManager.instance.CurrentWeapon].Name;
        Level.text = GameManager.instance.Weapons[GameManager.instance.CurrentWeapon].Level.toString;
    }

}
