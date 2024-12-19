using System;
using Enemy.Attack;
using Enemy.Movement;
using UnityEngine;

namespace Enemy
{
    public class EnemyAi : MonoBehaviour
    {
        [Header("Attack Components")]
        [SerializeField] private EnemyAttackDistance attackDistance;
        [SerializeField] private EnemyAttackFire attackFire;
        [SerializeField] private EnemyAttackMelee attackMelee;

        [Space(10)]
        [Header("Movement Components")]
        [SerializeField] private EnemyMovementPatrol movementPatrol;
        
        [Space(10)]
        [Header("Dependencies")]
        [SerializeField] private Transform player;
        
        [Space(10)]
        [Header("Enemy Properties")]
        [SerializeField] private int health = 100;

        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void Start()
        {
            if (!player)
            {
                player = GameObject.FindGameObjectWithTag("Player").transform;
                Debug.LogWarning("Player has not been found but player find object with tag 'Player'");
            }
            
            attackDistance.SetDependencies(player);
            attackFire.SetDependencies(player);
            attackMelee.SetDependencies(player);
        }

        private void Update()
        {
            float distance = Vector3.Distance(player.position, _transform.position);
            
            // if (health <= 50)
            // {
            //     attackFire.Attack();
            // }
            // else switch (distance)
            // {
            //     case <= 5:
            //         attackMelee.Attack();
            //         break;
            //     case <= 10:
            //         attackDistance.Attack();
            //         break;
            //     default:
            //         movementPatrol.Move();
            //         break;
            // }
        }
    }
}