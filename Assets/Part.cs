using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//:) This script is responsible for:
public class Part : MonoBehaviour
{
     public List<Connector> connectors = new List<Connector>();
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void AddConnector(Vector2 pos, string type) //TODO: make this into an editor function
    {
        Connector connector = new Connector(transform, pos, type);
    }
}
