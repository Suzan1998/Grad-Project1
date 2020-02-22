using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redHealth: MonoBehaviour
{
	public AudioSource finalMagicSound;
	public AudioSource hitSound; 
    public int enemyhealth = 30;
	public GameObject PhysicalPanel1;
	public GameObject PhysicalPanel2;
	public GameObject PhysicalPanel3;
	public GameObject red;
	  

    void Update()
    {
		
		if(finalMagicSound.isPlaying)
		{
			return;
		}
        if (enemyhealth <= 0)
		{
			
			StartCoroutine (sound());
			//finalMagicSound.Play();
			
			
		} 
    }
	
	
	  void DeductPoints (int hitpoints)
	{
		StartCoroutine(hitsound());
       enemyhealth -= hitpoints;
	   
    }
	
	IEnumerator sound()
	{
		finalMagicSound.Play();
        yield return new WaitForSeconds(1);
		PhysicalPanel1.SetActive(true);
		PhysicalPanel2.SetActive(true);
		yield return new WaitForSeconds(3);
		PhysicalPanel2.SetActive(false);
		PhysicalPanel3.SetActive(true);
		yield return new WaitForSeconds(3);
		PhysicalPanel1.SetActive(false);
		Destroy(gameObject);
		Destroy(red);
		 
	}
	
	
	IEnumerator hitsound()
	{
		yield return new WaitForSeconds(0.3f);
		hitSound.Play();
        
		
		 
	}
}
