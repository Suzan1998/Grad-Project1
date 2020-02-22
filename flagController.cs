using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class flagController : MonoBehaviour
{
	public GameObject tex1;
	public GameObject tex2;
	public GameObject tex3;
	public GameObject Button1;
	public GameObject Button2;
	public GameObject Button3;
	public GameObject flagImage;
	public GameObject correctBubble;
	public GameObject wrongBubble;
	public AudioSource correctSound;
	public AudioSource wrongSound;
	public GameObject NextPanel;
	private int i;//panelNumber
	public string[] B1choices;
	public string[] B2choices;
	public string[] B3choices;
    public Sprite[] flags= new Sprite[10];
	public GameObject DonePanel;
	public GameObject flagspanel;
	string flagnameLower;
	string flagnameUpper;
	string t1;
	string t2;
	string t3;
	
	
    // Start is called before the first frame update
    void Start()
    {
        i=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator actionsForTrue()
	{
		    
			correctBubble.SetActive(true);
			checkIfGameHasDone();
			yield return new WaitForSeconds(2);
			NextPanel.SetActive(true);
		    yield return new WaitForSeconds(2);
			NextPanel.SetActive(false);
			correctBubble.SetActive(false);
			flagImage.GetComponent<Image>().sprite=flags[i];
			tex1.GetComponent<Text>().text=B1choices[i];
			tex2.GetComponent<Text>().text=B2choices[i];
			tex3.GetComponent<Text>().text=B3choices[i];
			
		    Button1.GetComponent<Image>().color= Color.white;
			Button2.GetComponent<Image>().color= Color.white;
			Button3.GetComponent<Image>().color= Color.white;
			
			
			
			
			
	}
	IEnumerator actionsForFalse()
	{   
	
	        wrongBubble.SetActive(true);
			checkIfGameHasDone();
			yield return new WaitForSeconds(2);
			NextPanel.SetActive(true);
		    yield return new WaitForSeconds(2);
			NextPanel.SetActive(false);
			wrongBubble.SetActive(false);
			flagImage.GetComponent<Image>().sprite=flags[i];
			tex1.GetComponent<Text>().text=B1choices[i];
			tex2.GetComponent<Text>().text=B2choices[i];
			tex3.GetComponent<Text>().text=B3choices[i];
			Button1.GetComponent<Image>().color= Color.white;
			Button2.GetComponent<Image>().color= Color.white;
			Button3.GetComponent<Image>().color= Color.white;
	}
	
	
	public void check1()
	    { 
		i++;
		 flagnameLower= flagImage.GetComponent<Image>().sprite.name;
		 flagnameUpper=flagnameLower.ToUpper();
		 t1= Button1.GetComponentInChildren<Text>().text;
		if(t1==flagnameUpper)
		{
			Button1.GetComponent<Image>().color=Color.green;
		    correctSound.Play();
			StartCoroutine(actionsForTrue());
		}
		
		 else
	    {
		   Button1.GetComponent<Image>().color= Color.red;
			wrongSound.Play();
			StartCoroutine(actionsForFalse());
	    }
	}
   	
	
	public void check2()
	    { 
		i++;
		 flagnameLower= flagImage.GetComponent<Image>().sprite.name;
		 flagnameUpper=flagnameLower.ToUpper();
		 t2= Button2.GetComponentInChildren<Text>().text;
		if(t2==flagnameUpper)
		{
			Button2.GetComponent<Image>().color=Color.green;
		    correctSound.Play();
			StartCoroutine(actionsForTrue());
		}
		
		 else
	    {
		   Button2.GetComponent<Image>().color= Color.red;
			wrongSound.Play();
			StartCoroutine(actionsForFalse());
	    }
	}
	
	
	public void check3()
	    { 
		i++;
		flagnameLower= flagImage.GetComponent<Image>().sprite.name;
		flagnameUpper=flagnameLower.ToUpper();
		t3= Button3.GetComponentInChildren<Text>().text;
		if(t3==flagnameUpper)
		{
			Button3.GetComponent<Image>().color=Color.green;
		    correctSound.Play();
			StartCoroutine(actionsForTrue());
		}
		
		 else
	    {
		   Button3.GetComponent<Image>().color= Color.red;
			wrongSound.Play();
			StartCoroutine(actionsForFalse());
	    }
	}
	public void checkIfGameHasDone()
	{
		
		if(i==9){
		StartCoroutine(Done());}
		
	}
	
	
	IEnumerator Done()
	{
		flagspanel.SetActive(false);
		NextPanel.SetActive(false);
		DonePanel.SetActive(true);
       yield return new WaitForSeconds(4);
	   DonePanel.SetActive(false);
	   
	}
	
	
}
