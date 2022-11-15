using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//:) This script is responsible for:
public class Connector : MonoBehaviour
{
    public Transform parent;
    public Vector2 pos;
    string type;

    public Connector(Transform parent,Vector2 inputPos, string inputString)
    {
        pos = inputPos;
        parent = this.parent;
        type = inputString;
    }
    void Start()
    {
        transform.parent = parent;

    }


    void Update()
    {
        
    }
}
