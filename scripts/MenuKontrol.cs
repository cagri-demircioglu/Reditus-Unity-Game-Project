using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour {


    
    public void Basla()
    {
        SceneManager.LoadScene("oyunEkrani");
    }

    public void MuteMenu()
    {
        AudioListener.pause = !AudioListener.pause;   
    }
    
    public void credits()
    {
        SceneManager.LoadScene("credits");
    }
    public void store()
    {
        SceneManager.LoadScene("store");
    }

}
