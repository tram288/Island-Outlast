using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    void Start()
    {
        
    }
     
     void Update(){
         
     }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("food")){
            Destroy (other.gameObject);
        }
         if (other.gameObject.CompareTag ("drink")){
            Destroy (other.gameObject);
        }
    }

      
}
