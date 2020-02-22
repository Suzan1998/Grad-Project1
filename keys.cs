using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keys : MonoBehaviour
{
  
  public GameObject scoreSystem;

  public GameObject Xred1; 	//for image state of key if its getten set it to tick
  	
  public GameObject Xgreen1; 	
	
  public GameObject Xblue1; 	
  
  public GameObject Xyellow1; 
  public Sprite tick;
  
    void Start()
    {
        scoreSystem=GameObject.FindGameObjectWithTag("scoreSystem");
    }


    void Update()
    {
		scoreSystem.GetComponent<ScoreScript>().addYellow();
		scoreSystem.GetComponent<ScoreScript>().addBlue();
		scoreSystem.GetComponent<ScoreScript>().addGreen();
		scoreSystem.GetComponent<ScoreScript>().addRed();
		
		//for Green Blocks
        if(scoreSystem.GetComponent<ScoreScript>().GreenScore==1)
		{
			Xgreen1.GetComponent<Image>().sprite=tick;
		}
		//for Red Blocks
		if(scoreSystem.GetComponent<ScoreScript>().RedScore==1)
		{
			Xred1.GetComponent<Image>().sprite=tick;
		}
		//for Yellow Blocks
		if(scoreSystem.GetComponent<ScoreScript>().YellowScore==1)
		{
		   Xyellow1.GetComponent<Image>().sprite=tick;
		}
		//for Blue Blocks
		if(scoreSystem.GetComponent<ScoreScript>().BlueScore==1)
		{
		   Xblue1.GetComponent<Image>().sprite=tick;
		}
    }
}
