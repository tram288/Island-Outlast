using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text winNote;
    public GameObject gameOver;
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
        void OnTriggerEnter(Collider other)
    {
        
        Stats Statistic = gameObject.GetComponent<Stats>();
        if (other.gameObject.CompareTag ("Finish")){
            Destroy (other.gameObject);
            gameOver.SetActive(true);
            winNote.text = "Level Completed";
            Destroy(player);
            Statistic.GameStop();
        }
    }
}
