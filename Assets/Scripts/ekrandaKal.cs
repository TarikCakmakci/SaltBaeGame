using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekrandaKal : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5.34f, 5.34f),
         Mathf.Clamp(transform.position.y,-4f,4f),transform.position.z);
    }
}
