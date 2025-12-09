using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartUI : MonoBehaviour
{
    public static int healthValue; //Static så vi kan referera till vår heartcollector script
    public int internalHealth;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    //public GameObject healthBar; 
    void Start()
    {
        healthValue = 300;
    }
    void Update()
    {
        internalHealth = healthValue;
        /*if (healthValue <= 0)
        {
            SceneManager.LoadScene(1);
        }
        healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(healthValue, 30);*/
        if(healthValue == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
        }
        if (healthValue == 2)
        {
            Heart2.SetActive(true);
            Heart3.SetActive(false);
        }
        if (healthValue == 3)
        {
            Heart3.SetActive(true);
        }
    }
}
