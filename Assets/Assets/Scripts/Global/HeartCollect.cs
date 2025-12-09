using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed;
    public AudioSource collectSound;
    public GameObject heart;
    void Update() 
    {
        rotateSpeed = 2;
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    private void OnTriggerEnter()
    {
         /*if (HeartUI.healthValue == 300)
         {
             //Do absolutly nothing
         }
         if (HeartUI.healthValue > 280 && HeartUI.healthValue < 300)
         {
             collectSound.Play();
             HeartUI.healthValue = 300;
             heart.SetActive(false);
         }
         if (HeartUI.healthValue <= 280)
         {
             collectSound.Play();
             HeartUI.healthValue += 20;
             heart.SetActive(false);
         }*/
        collectSound.Play();
        HeartUI.healthValue += 1;
        //heart.SetActive(false);
    }
}
