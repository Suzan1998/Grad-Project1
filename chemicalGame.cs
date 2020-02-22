using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemicalGame : MonoBehaviour
{
    
	public AudioSource hitSound; 
	public GameObject yellow;
	public GameObject ChemoicalPanel1;
	public GameObject ChemoicalPanel2;

	  public int enemyhealth = 30;
	  

    void Update()
    {
        if (enemyhealth <= 0)
		{
			
			StartCoroutine(puzzel());
			
		} 
    }
	//
	
	  void DeductPoints (int hitpoints)
	{
		hitSound.Play();
       enemyhealth -= hitpoints;
	   
    }
	
	
	IEnumerator puzzel()
	{
		yield return new WaitForSeconds(0.5f);
		ChemoicalPanel1.SetActive(true);
		yield return new WaitForSeconds(4f);
		ChemoicalPanel1.SetActive(false);
		ChemoicalPanel2.SetActive(true);
		Destroy(yellow);
		
	}
}
