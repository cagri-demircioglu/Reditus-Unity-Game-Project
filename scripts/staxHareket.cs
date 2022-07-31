using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staxHareket : MonoBehaviour {

    public Rigidbody2D stax;
    public float staxHizi = 1.5f;
    


    void Start()
    {
        stax = this.GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {

        transform.Rotate(0, 0, 45 * Time.deltaTime*4);

    }
    void FixedUpdate()
    {
        stax.velocity = new Vector3(0, staxHizi);
    }
}
