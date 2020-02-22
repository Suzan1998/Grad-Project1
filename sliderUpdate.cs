using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderUpdate : MonoBehaviour
{
	private GameObject alice;
	public Slider AliceHealthSlider;
    // Start is called before the first frame update
    void Start()
    {
		alice=GameObject.FindGameObjectWithTag("alice");
		AliceHealthSlider.minValue=0;
        AliceHealthSlider.maxValue=100f;
    }

    // Update is called once per frame
    void Update()
    {
       AliceHealthSlider.value= alice.GetComponent<aliceDoneMove>().alicehealth;
    }
}
