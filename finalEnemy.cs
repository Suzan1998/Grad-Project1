using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class finalEnemy : MonoBehaviour
{
	
	public GameObject DestPoint;
	public GameObject repare;
	NavMeshAgent  theAgent;
	private GameObject alice;
	Transform junko;
	Animation anim;
	int Rotspeed=20;
	 public int hitpoints = 10;
    public float totarget;
    public float range=20;
    void Start()
    {
		anim=repare.GetComponent<Animation>();
		alice=GameObject.FindGameObjectWithTag("alice");
        theAgent= GetComponent<NavMeshAgent>();
		junko= theAgent.transform;
    }

    void Update()
    {
		var distance = Vector3.Distance(alice.transform.position, junko.position);
		if(distance>20)
		{
		anim.Play("cast1");
        //repare.transform.RotateAround(DestPoint.transform.position,Vector3.up,Rotspeed*Time.deltaTime);
		}
		else if(distance<=4)
		{if(distance<2)
		{
			anim.Play("attackingRepare");
						RaycastHit hit ;
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit))
		{
        totarget = hit.distance;
          if (totarget < range)
         {
		hit.transform.SendMessage("DeductPoints", hitpoints, SendMessageOptions.DontRequireReceiver);
         }
       }	
		}
			anim.Play("float");
			theAgent.SetDestination(alice.transform.position);
			
			
		}
    }
}
