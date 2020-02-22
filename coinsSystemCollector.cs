using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinsSystemCollector : MonoBehaviour
{
    private GameObject CoinsCollectScript;
	public AudioSource AudioCoin;
	
	
	void Start()
	{
		CoinsCollectScript=GameObject.FindGameObjectWithTag("coinSystem");
		
	}
IEnumerator OnTriggerEnter(Collider col){
	if(col.tag=="Player")
	{
     AudioCoin.Play();
	 transform.position=new Vector3(0,-1000,0);
	 yield return new WaitForSeconds(1f);
	 Destroy(gameObject);
     CoinsCollectScript.GetComponent<CoinSystem>().coinscollect += 1;
     CoinsCollectScript.GetComponent<CoinSystem>().addCoins();
	 yield return new WaitForSeconds(1.5f);
	 Destroy(gameObject);
	}
 }
}
