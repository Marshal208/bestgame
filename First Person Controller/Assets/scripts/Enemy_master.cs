using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_master : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    public bool isAngered;

    public float timeBetweenAttacks;
    bool alreadyAttacked;

    public GameObject Bullet;

    public NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if (Distance <= 50)
        {
            isAngered = true;
        }
        if (Distance > 50f)
        {
            isAngered = false;
        }

        if (isAngered)
        {
            _agent.isStopped = false;

            _agent.SetDestination(Player.transform.position);
        }
        if (!isAngered)
        {
            _agent.isStopped = true;
        }
        if (isAngered)
        {
            transform.LookAt(Player.transform);
        }
        if (isAngered)
        {
            GameObject bullet = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
        }
    }
}
