using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public float hunger;
    public float hungerOverTime;
    public float thirst;
    public float thirstOverTime;

    public Slider hungerBar;
    public Slider thirstBar;

    //public float foodEnergy;
    //public float drinkEnergy;

    public Text deathNote;
    public GameObject gameOver;
    public GameObject player;
    

    Rigidbody body;

    void Start()
    {
       body = GetComponent<Rigidbody>(); 
       hungerBar.maxValue = hunger;
       thirstBar.maxValue = thirst;

       UpdateUI();
    }

    void Update()
    {
        Calc();
    }

    private void Calc(){
        hunger -= hungerOverTime * Time.deltaTime;
        thirst -= thirstOverTime * Time.deltaTime;
        UpdateUI();

        if (hunger <= 0){
            Destroy (player);
            gameOver.SetActive(true);
            deathNote.text = "You died of starvation";
            GameStop();
        }
        else if (thirst <= 0){
            Destroy (player);
            gameOver.SetActive(true);
            deathNote.text = "You died of thirst";
            GameStop();
        }
    }
      public void UpdateUI(){
        hunger = Mathf.Clamp(hunger, 0, 100f);
        thirst = Mathf.Clamp(thirst, 0, 100f);

        hungerBar.value = hunger;
        thirstBar.value = thirst;

    }

    //   void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag ("food")){
    //        hunger += hungerOverTime * foodEnergy;
    //        UpdateUI();
    //    }

    //     if (other.gameObject.CompareTag ("drink")){
    //        thirst += thirstOverTime * drinkEnergy;
    //        UpdateUI();
    //    }
    //}

    public void ChangeEat (float changeHunger)
    {
        hunger += hungerOverTime * changeHunger;
        UpdateUI();
    }
    public void ChangeDrink (float changeThirst)
    {
        thirst += thirstOverTime * changeThirst;
        UpdateUI();  
    }
    public void GameStop(){
        enabled = false;
    }
   

}

