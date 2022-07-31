using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketKontrol : MonoBehaviour {

    

	void Start ()
    {

    }
	
	void Update ()
    {
        
        transform.Rotate(0, 0, 45 * Time.deltaTime);
        
    }

}
