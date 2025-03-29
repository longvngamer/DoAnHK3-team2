using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NavRun : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject desPos;
    [field:SerializeField] public NavMeshAgent navMeshAgent {get;private set;}
    [field:SerializeField] public GameObject desPos {get;private set;}
    [field:SerializeField] public Animator animator {get;private set;}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,desPos.transform.position) > navMeshAgent.stoppingDistance) {
            navMeshAgent.SetDestination(desPos.transform.position);
            animator.SetBool("run", true);
        }else {
            animator.SetBool("run",false);
        }
        
    }
}
