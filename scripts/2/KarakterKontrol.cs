using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class KarakterKontrol : MonoBehaviour {

    Rigidbody2D fizik;
    public int ivmelenme;
    public int KarakterDonmeHizi;
    int kazanilanPuan;
    bool oyunBitti;
    OyunKontrol oyunKontrol;
    public TextMeshProUGUI puanText;
    public TextMeshProUGUI staxText;
    AudioSource[] sesler;
    int staxPuani;
    int yuksekSkor = 0;
    int toplamStaxPuani;

	void Start ()
    {
        fizik = GetComponent<Rigidbody2D>();
        fizik.AddForce(new Vector2(ivmelenme, 0));
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrol").GetComponent<OyunKontrol>();
        sesler = GetComponents<AudioSource>();
        yuksekSkor = PlayerPrefs.GetInt("yuksekSkor");
        toplamStaxPuani = PlayerPrefs.GetInt("toplamStaxPuani");


        

	}
	
	void Update ()
    {
        {
            karakterHareket();
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="puan")
        {
            kazanilanPuan++;
            sesler[2].Play();
            puanText.text = "" + kazanilanPuan;

            if(kazanilanPuan>=10)
            {
                puanText.fontSize = 600;
                if (kazanilanPuan>=100)
                {
                    puanText.fontSize = 350;
                }
            }


            
                
        }
        if(col.gameObject.tag=="engel")
        {
            oyunBitti = false;
            sesler[1].Play();
            oyunKontrol.OyunBitti();
            Debug.Log(yuksekSkor);

            GetComponent<BoxCollider2D>().enabled = false;
            if(kazanilanPuan>yuksekSkor)
            {
                yuksekSkor = kazanilanPuan;
                PlayerPrefs.SetInt("yuksekSkor", yuksekSkor);
                Debug.Log(yuksekSkor);
            }

            Invoke("anaMenuyeDon", 2);
        }
        if(col.gameObject.tag=="stax")
        {
            staxPuani++;
            PlayerPrefs.SetInt("staxPuani", staxPuani);
            toplamStaxPuani = toplamStaxPuani + staxPuani;
            PlayerPrefs.SetInt("toplamStaxPuani", toplamStaxPuani);
            //burda toplamStaxPuani Hesaplaniyor.

            Destroy(col.gameObject);
            staxText.text = "" + staxPuani;
            sesler[2].Play();
        }
    }

    void anaMenuyeDon()
    {
        PlayerPrefs.SetInt("puanKayit", kazanilanPuan);
        SceneManager.LoadScene("anaMenu");
    }

    void karakterHareket()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (fizik.velocity.x < 0)
            {
                fizik.velocity = new Vector2(0, 0);
                fizik.AddForce(new Vector2(ivmelenme, 0));
                sesler[0].Play();

            }

            else if (fizik.velocity.x > 0)
            {
                fizik.velocity = new Vector2(0, 0);
                fizik.AddForce(new Vector2(-ivmelenme, 0));
                sesler[0].Play();
            }
        }
    }



}
