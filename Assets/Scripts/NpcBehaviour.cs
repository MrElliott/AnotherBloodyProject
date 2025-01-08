using UnityEngine;
using UnityEngine.AI;

public class NpcBehaviour : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField]
    private Transform target;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
