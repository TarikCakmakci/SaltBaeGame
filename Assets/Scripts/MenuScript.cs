using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Text rekor;
    
    
    void Start()
    {
        rekor.text = PlayerPrefs.GetFloat("Rekor").ToString();
    }
    
    public void OyunaBasla()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void OyunuKapat()
    {
        Debug.Log("Çıkış yapıldı.");
        Application.Quit();
        
    }
    public void OyunuDurdur()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OyunaDevamEt()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        
    }
}
