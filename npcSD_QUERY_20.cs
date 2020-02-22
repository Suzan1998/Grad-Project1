using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcSD_QUERY_20 : MonoBehaviour
{
	
	public GameObject DestPoint;
	public NavMeshAgent  theAgent;
	
    void Start()
    {
       
    }

    void Update()
    {
        theAgent.SetDestination(DestPoint.transform.position);
    }
}

