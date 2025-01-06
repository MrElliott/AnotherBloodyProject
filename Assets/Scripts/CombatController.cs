using UnityEngine;

public class CombatController : MonoBehaviour
{
    private Animator animator;

    private string Attack = "Attack";
    
    private bool attacking = false;

    private Transform weaponLeft;
    private Transform weaponRight;
    
    private MeshCollider leftWeaponCollider = null;
    private MeshCollider rightWeaponCollider = null;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        animator = GetComponentInChildren<Animator>();
        
        weaponLeft = Helpers.FindChildRecursive(transform,"WeaponLeft");
        weaponRight = Helpers.FindChildRecursive(transform, "WeaponRight");

        if(weaponLeft != null)
            leftWeaponCollider = weaponLeft.GetComponentInChildren<MeshCollider>();
        
        if(weaponRight != null)
            rightWeaponCollider = weaponRight.GetComponentInChildren<MeshCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            attacking = true;
            UpdateVariables();
        }
    }

    public void AnimStart(){
        //Debug.Log("AnimStart");
        attacking = false;
        UpdateVariables();

        if (rightWeaponCollider != null){
            rightWeaponCollider.enabled = true;
        }
    }

    public void AnimEnd(){
        //Debug.Log("AnimEnd");
        if (rightWeaponCollider != null)
            rightWeaponCollider.enabled = false;

    }

    private void UpdateVariables(){
        animator.SetBool(Attack, attacking);
    }
}
