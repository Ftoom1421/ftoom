using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class العدةو : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    [SerializeField] private float time = 5;
    private float bulletTime;
    public GameObject enemyBullet;
    public Transform spawnPoint;
    [SerializeField] private enemydata DM;
    // Start is called before the first frame update
    void Start()
    {
        if (Player != null)
        {
            enemy.SetDestination(Player.position);
            ShootAtPlayer();
            LookAtPlayer();

        }
    }

    private void LookAtPlayer()
    {
        var heading = transform.position - Player.position;
        var rotation = Quaternion.LookRotation(heading);
        transform.rotation = rotation;
    }


    private void ShootAtPlayer()
    {

        bulletTime -= Time.deltaTime;
        if (bulletTime > 0) return;
        {
            bulletTime = time;

            GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
            Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
            Destroy(bulletObj, 1f);
        }
        // Update is called once per frame
        void Update()
        {
        }
    }
}

internal class enemydata
{
    internal Vector3 m_speed;
}