using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    private Animator animator;
    
    private string damagedTrigger = "Damaged";
    private string deathTrigger = "Death";
    
    private bool death = false;
    private float deathTimer;
    private float deathTimerCounter = 10f;
    
    private void Start(){
        animator = GetComponent<Animator>();
    }

    private void Update(){
        if (death){
            deathTimer += Time.deltaTime;
            if (deathTimer >= deathTimerCounter){
                Destroy(this.gameObject);
            }
        }
    }

    public void TakeDamage(int damage){
        if (death)
            return;
        health -= damage;
        Debug.Log("Current Health: " + health);
        animator.SetTrigger(damagedTrigger);

        if (health <= 0){
            TriggerDeath();
        }
    }

    private void TriggerDeath(){
        Debug.Log("Game Object Died");
        animator.SetTrigger(deathTrigger);
        death = true;
        deathTimer = 0f;
    }
}
