using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toogleKontrol : MonoBehaviour {

	public void Start ()
    {
        if (AudioListener.pause)
        {
            GetComponent<Toggle>().isOn = true;
        }


    }
	
	// Update is called once per frame
	void Update ()
    {


    }
}
