using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cycling : MonoBehaviour
{
	
	public GameObject blueCubeKey1;
	public float speed=100f;
	public GameObject skeleton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
   {
	   OrbitAround();
   }
  
	
	public void OrbitAround()
	{
		//skeleton.GetComponent<Animation>().Play("walking");
		skeleton.GetComponent<Animation>().Play("dance");
		skeleton.transform.RotateAround(blueCubeKey1.transform.position,Vector3.up,speed*Time.deltaTime);
		
		
	}
}


