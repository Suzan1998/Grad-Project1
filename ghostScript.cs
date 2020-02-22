using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ghostScript : MonoBehaviour
{
	public GameObject Ghost;
	public GameObject DestPoint;
	int Rotspeed=20;
	NavMeshAgent  theAgent;
	private Animation anim;
	
    void Start()
    {
		anim=Ghost.GetComponent<Animation>();
        theAgent= GetComponent<NavMeshAgent>();
    }

    void Update()
    {
		anim.Play("ghostWalk");
       Ghost.transform.RotateAround(DestPoint.transform.position,Vector3.up,Rotspeed*Time.deltaTime);
		//anim.Play("dance");
    }
}
