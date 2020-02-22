using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mashDest : MonoBehaviour
{
	public GameObject mash;
	public int triggerrNo=0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	void OnTriggerEnter(Collider other)
	{
		
		if(other.gameObject==mash)
		{
			triggerrNo++;
			if((triggerrNo%2)==0)
			{
			this.gameObject.transform.position=this.gameObject.transform.position+new Vector3(0,0,50);
			}
		
			
			else
			{
				this.gameObject.transform.position=this.gameObject.transform.position+new Vector3(0,0,-30);
			}
		}
	}
	}

