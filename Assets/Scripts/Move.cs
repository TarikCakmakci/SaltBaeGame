using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject meat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 yeni = new Vector3(3, 0, 0);
        //transform.Translate(new Vector3(0, 0, 0) * Time.deltaTime);
        //transform.Translate(
        //Input.GetAxis("Horizontal") * Time.deltaTime * 9,
        //Input.GetAxis("Vertical") * Time.deltaTime * 0,
        //0);
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 kendiPos = new Vector3(transform.position.x, transform.position.y, 0);

        transform.position = Vector3.MoveTowards(kendiPos, new Vector3(mousePosition.x, transform.position.y, 0), Time.deltaTime*7);






    }
}
