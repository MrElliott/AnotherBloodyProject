using System;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField]
    private int damageDealt = 5;

    private float timer = 0f;
    private float damageCooldownTimer = 0.5f;

    private void Start(){
        timer = damageCooldownTimer;
    }

    private void Update(){
        timer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other){
        //Debug.Log("Damage Triggered");

        if (other.TryGetComponent(out Health health) && timer >= damageCooldownTimer){
            health.TakeDamage(damageDealt);
            timer = 0f;
        }
    }
}
