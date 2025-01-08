using System;
using UnityEngine;

public class NpcAnimationController : MonoBehaviour{
    Animator animator;
    
    private string animatorSpeedKey = "Speed";
    private Vector3 lastPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("MotionSpeed", 1f);
        
        lastPosition = transform.position;
    }


    private void Update(){
        float speed = (lastPosition- transform.position).magnitude*100f;
        lastPosition = transform.position;
        animator.SetFloat(animatorSpeedKey, speed);
    }

    private void OnFootstep(AnimationEvent animationEvent){
    }
}
