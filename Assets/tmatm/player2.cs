using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletspown;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool moving = false;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // this code it,s same transform.position = transform.position + Vector3.forward
            rb.velocity += Vector3.forward;
            moving = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity += Vector3.back;
            moving = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity += Vector3.right;
            moving = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity += Vector3.left;
            moving = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            StartCoroutine(Shoot());

        }
        if (moving == false)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * 7, ForceMode.Impulse);
            //rb.AddForce(Vector3.up, ForceMode.Impulse); FOR add force   واذا نبغاه يوقف نحط داون لانهايي يعني يطير ويطيرررررر مايوقف

        }


    }
    private IEnumerator Shoot()
    {

        Instantiate(bullet, bulletspown.position, Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        Instantiate(bullet, bulletspown.position, Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        Instantiate(bullet, bulletspown.position, Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
    }

}