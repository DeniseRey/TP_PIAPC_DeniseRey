using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    public bool colision=false;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            if(gameObject.tag=="Luz2"){
                gameObject.GetComponent<Light>().color = Color.blue;   
            }
            if(gameObject.tag=="Luz3"){
                gameObject.GetComponent<Light>().color = Color.green;   
            }
            colision=true;
            
        }

        
    }

}
