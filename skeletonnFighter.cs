﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class skeletonnFighter : MonoBehaviour
{
	public GameObject scoreSystem;
	public float Rotspeed=15f;
	public GameObject skeleton;
	public AudioSource hitSound; 
	public AudioSource die; 
	public AudioSource attack; 
	public GameObject target;
	public int moveSpeed;
	public int enemyhealth = 50;
	public NavMeshAgent enemy;
	Transform EnemyTransform;
     Animation anim;
	  public int hitpoints = 10;
    public float totarget;
    public float range=20 ;
	bool aliceIsNear=false;
	bool isIdle=false;
	bool isWalking=false;
	bool isDamaging=false;
	bool dead=false;
    
	
	void Start()
	{
		EnemyTransform= enemy.transform;//for skeleton
		anim = enemy.GetComponent<Animation> ();
		aliceIsNear=false;
	}
	
     
    void Update()
    {
	var distance = Vector3.Distance(target.transform.position, EnemyTransform.position);
		if(anim.isPlaying&&(!isIdle))
		{
			return;
		}

     else 
    {
	
	if (enemyhealth <= 0)
		{
		isIdle=false;
		isWalking=false;
		isDamaging=false;
		dead=true;
	    anim.Play("Dead");
		die.Play();
		//
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
		 enemy.SetDestination(target.transform.position);
		 anim.Play("walking");
		 isWalking=true;
       //  anim.Play("Attack1");
    }
	 
     else if(distance<=10)
	 {   
        
		aliceIsNear=true;
		attack.Play();
         //move towards the player
		anim.Play("attack2");
			
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
    }//update
	//
	
	void DeductPoints (int hitpoints)
	{
		hitSound.Play();
		isDamaging=true;
		anim.Play("Damage");
       enemyhealth -= hitpoints;
	   
    }
	
	
	IEnumerator done()
	{
		
	
	yield return new WaitForSeconds(2);
	scoreSystem.GetComponent<ScoreScript>().killedSkeletonNo+=1;
	scoreSystem.GetComponent<ScoreScript>().addKilledSkeletons();
	Destroy(gameObject);
	}
	
}
