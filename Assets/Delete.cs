using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//:) This script is responsible for:
public class Delete : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 dir = (transform.position - Input.mousePosition).normalized;
            transform.position += dir * 0.01f;
        }
       // transform.position = new Vector2(transform.position.x +Input.GetAxis("Horizontal")*0.01f, transform.position.y +Input.GetAxis("Vertical")*0.01f);
        //float x = Input.mousePosition.x / 1920;
        //float y = Input.mousePosition.y / 1080;
        //transform.position = new Vector2(x, y);
    }
}
