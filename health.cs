using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
	
	public AudioSource hitSound; 
	
	
	  public int enemyhealth = 100;
	  

    void Update()
    {
        if (enemyhealth <= 0)
		{
			Destroy(gameObject);
		} 
    }
	
	
	  void DeductPoints (int hitpoints)
	{
		hitSound.Play();
       enemyhealth -= hitpoints;
	   
    }
}
