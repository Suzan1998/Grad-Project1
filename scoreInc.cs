using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreInc : MonoBehaviour
{
	
	 public Text score;
	 public int i;
    // Start is called before the first frame update
    void Start()
    {
        int i=0;
    }

    // Update is called once per frame
    void Update()
    {
   
 StartCoroutine(inc());    
    }
	
	
	
	IEnumerator inc()
	{
		
			yield return new WaitForSeconds(1f);
			 i++;
			addScore();

	}
	public void addScore()
	{
		score.text=""+i;
	}
}
