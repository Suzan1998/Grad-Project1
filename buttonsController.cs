using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonsController : MonoBehaviour
{
	private GameObject scoreSystem;// for trials 

	
	public GameObject Panel2;
	public GameObject GameOver;
	public GameObject Panel3;
	public GameObject Panel4;
	public GameObject HintPanel;
	public GameObject Puzzel1Done;
	public GameObject tryAgain;
	public GameObject Puzzel2;
	public GameObject firstImage;
	public GameObject secondImage;
	public GameObject result;
	public Sprite[] elements= new Sprite[5];// element0=H2, 1=O, 2=Ca, 3=H2O, 4=NOOOO
	public AudioSource waterSound;
	public AudioSource error;
	
  
	

    void Start()
    {
        scoreSystem=GameObject.FindGameObjectWithTag("scoreSystem");
    }
    void Update()
    {
        
    }
	public void Next1Buton()
	{
		Panel2.SetActive(false);
		Panel3.SetActive(true);
	}
	
	
	public void Next2Buton()
	{
		Panel3.SetActive(false);
		Panel4.SetActive(true);
	}
	
	public void Next3Buton()
	{
		Puzzel1Done.SetActive(false);
		Panel4.SetActive(false);
		Puzzel2.SetActive(true);
	}
	
	public void onHintClick()
	{
		StartCoroutine(Hint());
	}
	
	
	public void onH2Click()
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
	public void onOClick()
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
	
	public void onCaClick()
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
	
	
	public void onEqualClick()
	{
		if(((firstImage.GetComponent<Image>().sprite)==elements[0])&&((secondImage.GetComponent<Image>().sprite)==elements[1]))
		{
			result.GetComponent<Image>().sprite=elements[3];
			waterSound.Play();
			StartCoroutine(GreatJob());
		}
		
		else if(((firstImage.GetComponent<Image>().sprite)==elements[1])&&((secondImage.GetComponent<Image>().sprite)==elements[0]))
		{
			result.GetComponent<Image>().sprite=elements[3];
			waterSound.Play();
			StartCoroutine(GreatJob());
		}
		
		else
		{
			result.GetComponent<Image>().sprite=elements[4];///wrong
			error.Play();
			StartCoroutine(BadJob());
			scoreSystem.GetComponent<ScoreScript>().trialCase1 +=1;
	        scoreSystem.GetComponent<ScoreScript>().addTrialCase1();
			if(scoreSystem.GetComponent<ScoreScript>().trialCase1==3)
			{
				StartCoroutine(ExitPuzzle());
			}
			
		}
		
		
	}
	
	IEnumerator GreatJob()
	{
		yield return new WaitForSeconds(1f);
		Puzzel1Done.SetActive(true);
		//winPanel.SetActive(true);
		
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

