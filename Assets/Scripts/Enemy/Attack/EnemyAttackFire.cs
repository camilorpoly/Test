using UnityEngine;

namespace Enemy.Attack
{
    public class EnemyAttackFire : MonoBehaviour
    {
        private Transform _player;

        public void SetDependencies(Transform player)
        {
            if (!player)
            {
                Debug.LogError("Player is null");
                return;
            }
            _player = player;
        }
        
        public void Attack()
        {
            print($"Atacando al jugador - {_player.name} con Fuego");
        }
    }
}