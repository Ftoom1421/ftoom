using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    private const double V = 0.0;
    [SerializeField] private GameObject m_bullet;

    [SerializeField] private Transform bulletsspawnpoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Invoke("Shoot", 0.0f);
        }
    }

    private void Shoot()
    {
        Instantiate(m_bullet, bulletsspawnpoint.position, Quaternion.identity);

    }
}
