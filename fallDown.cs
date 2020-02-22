using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour
{
	public GameObject scoreSystem;
	public GameObject blueCube;
	public GameObject blue;
	Animation anim;
	
    void Start()
    {
        anim=blue.GetComponent<Animation>();
    }


    void Update()
    {
        if(scoreSystem.GetComponent<ScoreScript>().SkeletonDeadNo==3)
		{
			anim.Play("blueDownn");
			
			StartCoroutine(stopp());
			
			
		}
    }
	IEnumerator stopp()
	{
		
		yield return new WaitForSeconds(1);
		Destroy(blueCube);
	}
}
