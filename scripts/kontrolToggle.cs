using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class kontrolToggle : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        if (AudioListener.pause)
        {
            GetComponent<Toggle>().isOn = true;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
