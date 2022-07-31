using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKontrol : MonoBehaviour {

    Rigidbody2D fizik;
    public int ivmelenme;
    public int KarakterDonmeHizi;

	void Start ()
    {
        fizik = GetComponent<Rigidbody2D>();
        fizik.AddForce(new Vector2(ivmelenme, 0));
        

	}
	
	void Update ()
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (fizik.velocity.x < 0)
                {
                    fizik.velocity = new Vector2(0, 0);
                    fizik.AddForce(new Vector2(ivmelenme, 0));
                    
                }

                else if (fizik.velocity.x > 0)
                {
                    fizik.velocity = new Vector2(0, 0);
                    fizik.AddForce(new Vector2(-ivmelenme, 0));


                }
            }

            
        }

        if(fizik.velocity.x>0)
        {
            transform.Rotate(0, 0, 45*Time.deltaTime*KarakterDonmeHizi);
        }
        if(fizik.velocity.x<0)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime * KarakterDonmeHizi);
        }

	}
}
