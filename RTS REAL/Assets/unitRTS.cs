using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class unitRTS : MonoBehaviour
{
   public NavMeshAgent agent;
    public GameObject respawn;

    


    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        respawn = GameObject.Find("spawn");
        agent.SetDestination(respawn.gameObject.transform.position);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
