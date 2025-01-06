using System;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField]
    private int damageDealt = 5;
    
    private void OnTriggerEnter(Collider other){
        //Debug.Log("Damage Triggered");
        
        if(other.TryGetComponent(out Health health))
            health.TakeDamage(damageDealt);
    }
}
