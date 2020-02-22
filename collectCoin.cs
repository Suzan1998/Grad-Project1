using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour
{
    private GameObject CoinsCollectScript;
	public AudioSource AudioCoin;
	private GameObject scoreSystem;
	
	
	void Start()
	{
		scoreSystem=GameObject.FindGameObjectWithTag("scoreSystem");
	}
IEnumerator OnTriggerEnter(Collider col){
	if(col.tag=="alice")
	{
     AudioCoin.Play();
	 transform.position=new Vector3(0,-1000,0);
	 yield return new WaitForSeconds(0.5f);
	 Destroy(gameObject);
	 scoreSystem.GetComponent<ScoreScript>().collectedcoinsNo +=1;
	 scoreSystem.GetComponent<ScoreScript>().addCoins();

	}
 }
}
