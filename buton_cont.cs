using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buton_cont : MonoBehaviour {
	bool panelop;
	public GameObject market_panel;
	public int money;
	public GameObject karakter;

	public bool k1b;
	public bool k2b;
	public bool k3b;

	public Sprite k1s;
	public Sprite k2s;
	public Sprite k3s;

	public Sprite tick;


	public Image k2ds;
	public Image k3ds;

	public Text money_text;

	// Use this for initialization
	public void market_but(){
		panelop = !panelop;

	
	}
	public void k1(){
		karakter.GetComponent<SpriteRenderer> ().sprite = k1s;
	
	}
	public void k2(){
		if (!k2b && money >= 10) {
			money = money - 10;
			karakter.GetComponent<SpriteRenderer>().sprite = k2s;
			k2ds.sprite = tick;
			k2b = true;
		}
		if (k2b) {
		
			karakter.GetComponent<SpriteRenderer>().sprite = k2s;
		
		}
	
	}
	public void k3(){
		if (!k3b && money >= 10) {
			money = money - 10;
			karakter.GetComponent<SpriteRenderer>().sprite = k3s;
			k3ds.sprite = tick;
			k3b = true;
			
		}
		if (k3b) {

			karakter.GetComponent<SpriteRenderer>().sprite = k3s;
			
		}
	
	}

	void Start () {
		panelop = false;
		k1b = false;
		k2b = false;
		k3b = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (panelop) {
		
			market_panel.SetActive (true);
		} else {
			market_panel.SetActive(false);
		}

		money_text.text = money.ToString();
	}
}
