using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Folow : MonoBehaviour
{
    public Transform Player;
    public float Speed;
    public NavMeshAgent Enemy;
    public LayerMask whatIsPlayer;

    public float sightRange;
    public bool playerInSightRange;

    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (playerInSightRange) Follow();
        if (!playerInSightRange) StopFollow();

    }

    public void Follow()
    {
        Enemy.speed = Speed;
        Enemy.SetDestination(Player.position);
    }

    public void StopFollow()
    {
        Enemy.speed = 0;
    }
}
