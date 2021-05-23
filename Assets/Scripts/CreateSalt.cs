using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSalt : MonoBehaviour
{
    public GameObject salt;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("olustur", 1.2f,1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void olustur()
    {

        Vector3 pos = new Vector3(Random.Range(-5, 5), 6, Random.Range(0, 10));
        
        Instantiate(salt,pos,transform.rotation);
         
    }
}


