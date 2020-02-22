using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capitalsScripts : MonoBehaviour
{
	public GameObject PuzzelWelcomeCube;
	public GameObject Alice;
	public GameObject Panel1;
	public GameObject welcomePanel;
	public GameObject DescPanel;
	public GameObject Panel2;
	public GameObject SpeechBubbleT1;
	public GameObject SpeechBubbleT2;
	public GameObject Panel3;
    public GameObject Bubble;
	public AudioSource greenSound;
	public GameObject greenCube;
	public int enemyhealth = 30;
	public GameObject greentrigger;
	public GameObject green;
	public AudioSource hitSound; 
    public bool enabled;
	
	void Start()
	{
		enabled=true;
	}
	void Update()
	{
		 if (enemyhealth <= 0 &&enabled)
		{
			
			StartCoroutine(Instructions());
			enabled=false;
		} 
	}
	 
	  void DeductPoints (int hitpoints)
	{
		hitSound.Play();
       enemyhealth -= hitpoints;
	   
    }
	
	  IEnumerator Instructions()
	  {
		  
		  //	greenSound.Play();
			//yield return new WaitForSeconds(2.5f);
			//greenSound.Stop();
			PuzzelWelcomeCube.SetActive(true);
			yield return new WaitForSeconds(4);
			PuzzelWelcomeCube.SetActive(false);
		    Panel1.SetActive(true);//111111111111111111111111111111111111111111111111111111111111111111111111
			
			yield return new WaitForSeconds(0.2f);
			
	        welcomePanel.SetActive(true);
			yield return new WaitForSeconds(3);
		    welcomePanel.SetActive(false);
            DescPanel.SetActive(true);
			yield return new WaitForSeconds(6);
			Panel1.SetActive(false);//panel one done
			Panel2.SetActive(true);///2222222222222222222222222222222222222222222222222
			yield return new WaitForSeconds(0.1f);
			SpeechBubbleT1.SetActive(true);
			yield return new WaitForSeconds(2);
		    SpeechBubbleT1.SetActive(false);
			yield return new WaitForSeconds(0.7f);
			SpeechBubbleT2.SetActive(true);
			yield return new WaitForSeconds(3);
			SpeechBubbleT2.SetActive(false);
			Bubble.SetActive(false);
			yield return new WaitForSeconds(0.7f);
			Panel3.SetActive(true);
			//enabled=true;
			//Destroy(greentrigger);
			
			
			
	  }
}
