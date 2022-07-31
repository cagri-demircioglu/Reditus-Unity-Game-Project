using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour {

    public GameObject engel;
    public int engelSayisi = 10;
    public float engelHiz = -1.5f;
    GameObject[] engeller;
    public float degisimZaman = 0;
    int sayac = 0;
    bool oyunBitti = true;
    KarakterKontrol karakterKontrol;
    public Animator animator;
    public GameObject staxPrefab;
    public Vector2 randomPos;
    public float baslangicBekleme;
    public float olusturmaBekleme;
    public float donguBekleme;
    //public GameObject karakterSpawner;
    
    
    
    

	void Start ()
    {

        /*
         * Vector2 karakterSpawn = new Vector2(0, -1.362f);
           Instantiate(karakterSpawner, karakterSpawn, Quaternion.identity);

    */
           engeller = new GameObject[engelSayisi]; 
        

        for (int i=0;i<engeller.Length;i++)
        {
            engeller[i] = Instantiate(engel, new Vector2(-20, -20), Quaternion.identity);
            Rigidbody2D fizikEngel = engeller[i].AddComponent<Rigidbody2D>();
            fizikEngel.gravityScale = 0;
            fizikEngel.velocity = new Vector2(0, engelHiz);
            karakterKontrol = GameObject.FindGameObjectWithTag("karakter").GetComponent<KarakterKontrol>();
             
            
        }


        StartCoroutine(staxOlustur());

    }

    void Update ()
    {
        if(oyunBitti)
        {
            engelHareketleri();
            
            
        }
        else
        {

        }
    }

    void engelHareketleri()
    {
        degisimZaman += (Time.deltaTime)*1.3f;
        if(degisimZaman>2.0f)
        {
            degisimZaman = 0;
            float xEkseni = Random.Range(-0.77f, 0.77f);
            engeller[sayac].transform.position = new Vector3(xEkseni, 2f);

            sayac++;

                if (sayac>=engeller.Length)
            {
                sayac = 0;
            }
        }
    }


    public void OyunBitti()
    {
        animator.SetTrigger("oyunBitti");
        for (int i = 0;i<engeller.Length;i++)
        {
            engeller[i].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            
        }
        karakterKontrol.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        
        oyunBitti = false;
    }

    IEnumerator staxOlustur()
    {
        if(oyunBitti)
        {
            yield return new WaitForSeconds(baslangicBekleme);
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Vector2 Staxvec = new Vector2(Random.Range(-randomPos.x, randomPos.x), randomPos.y);
                    Instantiate(staxPrefab, Staxvec, Quaternion.identity);
                    yield return new WaitForSeconds(olusturmaBekleme);
                }
                yield return new WaitForSeconds(donguBekleme);
            }
        }
        
        
        
    }


}
