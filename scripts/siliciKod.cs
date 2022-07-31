using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siliciKod : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "stax")
        {
            Destroy(other.gameObject);
        }
    }
}
