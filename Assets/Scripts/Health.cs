using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    public void TakeDamage(int damage){
        health -= damage;
        Debug.Log("Current Health: " + health);

        if (health <= 0){
            TriggerDeath();
        }
    }

    private void TriggerDeath(){
        Debug.Log("Game Object Died");
        Destroy(this.gameObject);
    }
}
