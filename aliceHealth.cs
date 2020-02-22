using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliceHealth : MonoBehaviour
{
	
	public AudioSource AliceScream; 
	private Animation anim;
	public GameObject Alice;
	
	public int alicehealth = 50;
	  


    void Start()
	{
		anim= Alice.GetComponent<Animation>();
	}

    void Update()
    {
		

        if (alicehealth <= 0)
		{
		
			anim.Play("Die");
			StartCoroutine(Wait());
			//Destroy(gameObject);
		} 
    }
	
	
	  void DeductPoints (int hitpoints)
	{
		//AliceScream.Play();
		//anim.Play("TakeDamage");
       alicehealth -= hitpoints;
	   
    }
	IEnumerator Wait()
	{
			yield return new WaitForSeconds(2);
            Destroy(gameObject);
	}
}
