using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesKontrol : MonoBehaviour
{

    public AudioSource sesDosyasi;
    private float muzikSesi = 1f;
    void Start()
    {
        sesDosyasi = this.GetComponent<AudioSource>();
    }

    
    void Update()
    {
        sesDosyasi.volume = muzikSesi;
    }
    public void sesAyarla(float vol)
    {
        muzikSesi = vol;
    }
}
