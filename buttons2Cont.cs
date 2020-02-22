using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class buttons2Cont : MonoBehaviour
{
  
	public GameObject Panel3;
	public GameObject game2d;
	public GameObject Panel4;
	public GameObject blockWin;
	public GameObject HintPanel;
	public GameObject Puzzel2Done;
	public GameObject tryAgain;
	public GameObject Puzzel2;
	public GameObject firstImage;
	public GameObject secondImage;
	public GameObject result;
	public Sprite[] elements= new Sprite[5];// element0=He, 1=H, 2=Cl, 3=HCL, 4=NOOOO
	public AudioSource reactionSound;
	public AudioSource error;
    ////////////////////////////////////
	public GameObject GameOver;
	private GameObject scoreSystem;
  
	

    void Start()
    {
     scoreSystem=GameObject.FindGameObjectWithTag("scoreSystem");
    }
    void Update()
    {
        
    }
	
	
	
	public void Next2Buton()
	{
		Panel3.SetActive(false);
		Panel4.SetActive(true);
	}
	
	public void Next3Buton()
	{
		Puzzel2Done.SetActive(false);
		Panel4.SetActive(false);
		//Puzzel2.SetActive(true);
	}
	
	public void onHintClick()
	{
		StartCoroutine(Hint());
	}
	
	
	public void onHClick()
	{
		if(((firstImage.GetComponent<Image>().sprite)==null)&&((secondImage.GetComponent<Image>().sprite)==null))
		{
			firstImage.GetComponent<Image>().sprite=elements[1];
		}
		else if(((firstImage.GetComponent<Image>().sprite)!=null)&&((secondImage.GetComponent<Image>().sprite)==null))
		{
			secondImage.GetComponent<Image>().sprite=elements[1];
		}
		else if (((firstImage.GetComponent<Image>().sprite)!=null)&&((secondImage.GetComponent<Image>().sprite)!=null))
		{
			firstImage.GetComponent<Image>().sprite=null;
			secondImage.GetComponent<Image>().sprite=null;
		}
		
	}
	public void onCLClick()
	{
		if(((firstImage.GetComponent<Image>().sprite)==null)&&((secondImage.GetComponent<Image>().sprite)==null))
		{
			firstImage.GetComponent<Image>().sprite=elements[2];
		}
		else if(((firstImage.GetComponent<Image>().sprite)!=null)&&((secondImage.GetComponent<Image>().sprite)==null))
		{
			secondImage.GetComponent<Image>().sprite=elements[2];
		}
		else if (((firstImage.GetComponent<Image>().sprite)!=null)&&((secondImage.GetComponent<Image>().sprite)!=null))
		{
			firstImage.GetComponent<Image>().sprite=null;
			secondImage.GetComponent<Image>().sprite=null;
		}
	}
	
	public void onHeClick()
	{
		if(((firstImage.GetComponent<Image>().sprite)==null)&&((secondImage.GetComponent<Image>().sprite)==null))
		{
			firstImage.GetComponent<Image>().sprite=elements[0];
		}
		else if(((firstImage.GetComponent<Image>().sprite)!=null)&&((secondImage.GetComponent<Image>().sprite)==null))
		{
			secondImage.GetComponent<Image>().sprite=elements[0];
		}
		else if (((firstImage.GetComponent<Image>().sprite)!=null)&&((secondImage.GetComponent<Image>().sprite)!=null))
		{
			firstImage.GetComponent<Image>().sprite=null;
			secondImage.GetComponent<Image>().sprite=null;
		}
	}
	
	
	public void onEqualClick()
	{
		if(((firstImage.GetComponent<Image>().sprite)==elements[1])&&((secondImage.GetComponent<Image>().sprite)==elements[2]))
		{
			result.GetComponent<Image>().sprite=elements[3];
			reactionSound.Play();
			StartCoroutine(GreatJob());
		}
		
		else if(((firstImage.GetComponent<Image>().sprite)==elements[2])&&((secondImage.GetComponent<Image>().sprite)==elements[1]))
		{
			result.GetComponent<Image>().sprite=elements[3];
			reactionSound.Play();
			StartCoroutine(GreatJob());
		}
		
		else
		{
			result.GetComponent<Image>().sprite=elements[4];///wrong
			error.Play();
			StartCoroutine(BadJob());
			scoreSystem.GetComponent<ScoreScript>().trialCase1 +=1;
	        scoreSystem.GetComponent<ScoreScript>().addTrialCase1();
			if(scoreSystem.GetComponent<ScoreScript>().trialCase1==4)
			{
				StartCoroutine(ExitPuzzle());
			}
		}
		
		
	}
	
	IEnumerator GreatJob()
	{
		yield return new WaitForSeconds(1f);
		Puzzel2Done.SetActive(true);
	    scoreSystem.GetComponent<ScoreScript>().YellowScore +=1;
	    scoreSystem.GetComponent<ScoreScript>().addYellow();
		yield return new WaitForSeconds(3f);
		Puzzel2Done.SetActive(false);
		Panel4.SetActive(false);
		blockWin.SetActive(true);
		game2d.SetActive(false);
		yield return new WaitForSeconds(3f);
		blockWin.SetActive(false);
		
	}
	
	
	IEnumerator Hint()
	{
		HintPanel.SetActive(true);
		yield return new WaitForSeconds(3f);
		HintPanel.SetActive(false);
		
	}
	
	
	IEnumerator BadJob()
	{
		yield return new WaitForSeconds(0.5f);
		tryAgain.SetActive(true);
		yield return new WaitForSeconds(3f);
		tryAgain.SetActive(false);
		
	}
	
	
	IEnumerator ExitPuzzle()
	{
	yield return new WaitForSeconds(0.5f);
	Panel4.SetActive(false);
	GameOver.SetActive(true);
	}
}
