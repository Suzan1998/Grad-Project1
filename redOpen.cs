using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redOpen : MonoBehaviour
{
  
  public AudioSource redSound;
  public GameObject red;
  public GameObject scoreSystem;
  public GameObject keys;
  Animation anim;
    void Start()
    {
		scoreSystem=GameObject.FindGameObjectWithTag("scoreSystem");
		keys=GameObject.FindGameObjectWithTag("keys");
      anim=red.GetComponent<Animation>();
    }
    void Update()
    {
        
    }
	void OnTriggerEnter (Collider other)
    {
        if (other.tag== "alice")
        {
			if(keys.GetComponent<keys>().Xred1.GetComponent<Image>().sprite==keys.GetComponent<keys>().tick)
			{
			StartCoroutine(openGate1());
			}
			if(keys.GetComponent<keys>().Xyellow1.GetComponent<Image>().sprite==keys.GetComponent<keys>().tick)
			{
			StartCoroutine(openGate2());
			}
			if(keys.GetComponent<keys>().Xblue1.GetComponent<Image>().sprite==keys.GetComponent<keys>().tick)
			{
			StartCoroutine(openGate4());
			}
			if(keys.GetComponent<keys>().Xgreen1.GetComponent<Image>().sprite==keys.GetComponent<keys>().tick)
			{
			StartCoroutine(openGate3());
			}
        }
    }
	
	
	IEnumerator openGate1()
	{
		//redSound.Play();
		yield return new WaitForSeconds(0.5f);
		anim.Play("openGateRed");
	}
	IEnumerator openGate2()
	{
		//redSound.Play();
		yield return new WaitForSeconds(0.5f);
		anim.Play("openGateYellow");
	}
	IEnumerator openGate3()
	{
		//redSound.Play();
		yield return new WaitForSeconds(0.5f);
		anim.Play("openGateGreen");
	}
	IEnumerator openGate4()
	{
		//redSound.Play();
		yield return new WaitForSeconds(0.5f);
		anim.Play("openGateBlue");
	}
}
