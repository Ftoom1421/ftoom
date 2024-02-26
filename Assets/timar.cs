using System;

using UnityEngine;
using UnityEngine.UI;

public class timar : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeValue = 90;
    public Text timerText;
    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 90;
        }
        DisplayTime(timeValue);

    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        // الحين عشان اذا صفر العداد مايكتب واحد ابيه يكتب صفر عشان كذا احط هذا السطرين اللي تحت عشان يخليها ليا زيرو 
        //else if (timeToDisplay > 0)
        //{
        //timeToDisplay += 1;
        //}
        float minutes = MathF.Floor(timeToDisplay / 60);
        float seconds = Mathf.Floor(timeToDisplay % 60);
        // عنده مشكله اللي اقل من السكند ماتصير صفر فتطلع بالشاشه واحد فهو بيكتب هالسطر عشان يحل المشكله 
        float milliseconds = timeToDisplay % 1 * 1000;
        // هنا استدعينا ال math.f عشان العمليه رياضيه وقلنا ترا المنت والسكند يساوون كذا رياضيا

        //
        //timerText.text = string.Format("{0;00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        timerText.text = timeValue.ToString();

    }

}

