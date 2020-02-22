using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    
	
    public int hitpoints = 10;
    public float totarget;
    public float range=0.1f;
	public GameObject skeleton;
	Animation anim;
	
    void Start()
    {
		
		
		
		anim=skeleton.GetComponent<Animation>();
        
    }
    void Update()
    {
		
	if(anim.IsPlaying("Attack1"))
		{
            RaycastHit hit ;
         if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit))
		{
        totarget = hit.distance;
          if (totarget < range)
         {
		hit.transform.SendMessage("DeductPoints", hitpoints, SendMessageOptions.DontRequireReceiver);
         }
        }
		}
    }
}
