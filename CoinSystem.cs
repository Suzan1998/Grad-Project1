using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{

 public int coinscollect = 0;
 public Text coinsNoText;
 
 
 public void addCoins()
	{
		coinsNoText.text=":"+coinscollect;
	}

}


