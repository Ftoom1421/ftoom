using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletspown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shooting());
    }
    //[SerializeField] privatee TextMeshProUGUI 
    private IEnumerator Shooting()
    {

        while (true)
        {
            Instantiate(bullet, bulletspown.position, Quaternion.identity);
            yield return new WaitForSeconds(0.25f);

        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

