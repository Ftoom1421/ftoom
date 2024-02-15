using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            InvokeRepeating("Shoot", 0.08f, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            CancelInvoke();
        }
    }

    private void Shoot()
    {
        Instantiate(m_bullet, transform.position, Quaternion.identity);

    }
}
