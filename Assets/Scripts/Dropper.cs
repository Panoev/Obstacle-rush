using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timeToWait = 8f ;
    Rigidbody rigidbody; 
    MeshRenderer renderer ;

    
    void Start()
    {
    renderer = GetComponent<MeshRenderer>();
    rigidbody = GetComponent<Rigidbody>();
    
    renderer.enabled = false;
    rigidbody.useGravity = false ; 
    }

    
    void Update()
    {
    
    if (Time.time > timeToWait) {
    renderer.enabled = true;
    rigidbody.useGravity = true;
    }


    }
}
