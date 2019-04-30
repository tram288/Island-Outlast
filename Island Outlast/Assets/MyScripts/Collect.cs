using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float foodEnergy;
    public float drinkEnergy;

    void Start()
    {
        
    }
     
     void Update(){
         
     }

    void OnTriggerEnter(Collider other)
    {
        
        Stats Statistic = gameObject.GetComponent<Stats>();
        if (other.gameObject.CompareTag ("food")){
            Destroy (other.gameObject);
            Statistic.ChangeEat(foodEnergy);
        }
        if (other.gameObject.CompareTag ("drink")){
            Destroy (other.gameObject);
            Statistic.ChangeDrink(drinkEnergy);
        }
    }

      
}
