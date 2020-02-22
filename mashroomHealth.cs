using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class mashroomHealth : MonoBehaviour
{
	public AudioSource die; 
	public AudioSource attack; 
	public AudioSource hitSound; 
	private Animation anim;
	public GameObject mashroom;
	public GameObject scoreSystem;
	public NavMeshAgent MashroomAgent;
	private GameObject target;
	public bool isWalking;
	public bool aliceIsNear;
	public float totarget;
	public int hitpoints = 10;
	public float range=20 ;
	public bool isIdle;
	Transform MashroomTransform;
	 public int enemyhealth = 50;
	  
    void Start()
	{
		target=GameObject.FindGameObjectWithTag("alice");
		MashroomTransform= MashroomAgent.transform;
		anim = MashroomAgent.GetComponent<Animation> ();
		isIdle=true;
	}

    void Update()
    {
		var distance = Vector3.Distance(target.transform.position, MashroomTransform.position);
		if(anim.isPlaying&&(!isIdle))
		{
			return;
		}


  else 
    {
	
	   if (enemyhealth <= 0)
		{
			isIdle=false;
			anim.Play("Death");
			//Destroy(gameObject);
			StartCoroutine(done());
		}


    else if(distance>50)
	 {
		isIdle=true;
		aliceIsNear=false;
		anim.Play("ready");
		
	 }	
		
		
	else if ((distance <= 50.0f)&&(distance>10))
	{
		aliceIsNear=true;
         //move towards the player
		 MashroomAgent.SetDestination(target.transform.position);
		 anim.Play("Run");
		 isWalking=true;
    }
     else if(distance<=10)
	 {   
		aliceIsNear=true;
		attack.Play();
         //move towards the player
		anim.Play("Attack");
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
		}
    }
	  void DeductPoints (int hitpoints)
	{
		hitSound.Play();
		//anim.Play("Damage");
       enemyhealth -= hitpoints;
	   
    }
	IEnumerator done()
	 {
	yield return new WaitForSeconds(1.5f);
	scoreSystem.GetComponent<ScoreScript>().killedMashNo+=1;
	scoreSystem.GetComponent<ScoreScript>().addKilledMashrooms();
	Destroy(gameObject);
	 }
    }
