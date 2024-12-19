using System;
using UnityEngine;

namespace Enemy
{
    public class EnemyTriggerActivator : MonoBehaviour
    {
        [SerializeField] private string triggerName;
        
        private void OnTriggerEnter(Collider other)
        {
            print($"Trigger Enter: {triggerName}");
        }

        private void OnTriggerExit(Collider other)
        {
            print($"Trigger Exit: {triggerName}");
        }
    }
}