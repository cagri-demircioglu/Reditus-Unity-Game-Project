using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class storeKontrol : MonoBehaviour {

    bool panelOnOff;
    public GameObject marketPanel;
    public Sprite karakterilksprite;
    public Sprite karakter2sprite;
    public Sprite karakter3sprite;
    public Sprite karakter4sprite;
    public Sprite karakter5sprite;
    public Sprite karakter6sprite;
    public Sprite karakter7sprite;
    public Sprite karakter8sprite;
    public Sprite karakter9sprite;
    public Sprite karakter10sprite;
    GameObject karaktereUlas;


    public TextMeshProUGUI staxStoreText;

	void Start ()
    {
        panelOnOff = false;
        staxStoreText.text = "" + PlayerPrefs.GetInt("toplamStaxPuani");
        karaktereUlas = GameObject.Find("karakter1");
        Debug.Log(karaktereUlas.tag);

        //degişecek kısım burası

	}
	
	void Update ()
    {
		if(panelOnOff)
        {
            marketPanel.SetActive(true);
        }
        else
        {
            marketPanel.SetActive(false);
        }
	}

    public void menu()
    {
        SceneManager.LoadScene("anaMenu");
    }

    public void panel()
    {
        panelOnOff = !panelOnOff;
    }

    public void karakter1()
    {
        karaktereUlas.GetComponent<SpriteRenderer>().sprite = karakterilksprite;
    }
    public void karakter2()
    {
        karaktereUlas.GetComponent<SpriteRenderer>().sprite = karakter2sprite;
    }
    public void karakter3()
    {

    }
    public void karakter4()
    {

    }
    public void karakter5()
    {

    }
    public void karakter6()
    {

    }
    public void karakter7()
    {

    }
    public void karakter8()
    {

    }
    public void karakter9()
    {

    }
    public void karakter10()
    {

    }

}
