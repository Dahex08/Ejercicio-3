using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Folow : MonoBehaviour
{
    public Transform Player;
    public float Speed;
    public NavMeshAgent Enemy;

    void Update()
    {
        Enemy.speed = Speed;
        Enemy.SetDestination(Player.position);

    }
}
