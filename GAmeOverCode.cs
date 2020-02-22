using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeOverCode : MonoBehaviour
{
	
	
	public GameObject panel;
	public AudioSource sound;
    public void PanelShow()
	{
		StartCoroutine(show());
	}
	
	
	
	IEnumerator show()
	{
		sound.Play();
		yield return new WaitForSeconds(0.1f);
		panel.SetActive(true);
		
		
	}
}
