using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool invOpen = false;
    public GameObject invMenu;
    public GameObject thePlayer;
    //public GameObject itemPanel;
    //public GameObject questPanel;
    //public GameObject statsPanel;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (invOpen == false)
            {
                Time.timeScale = 0;
                invOpen = true;
                //Cursor.visible = true;
                invMenu.SetActive(true);
                thePlayer.SetActive(false);
            }
            else
            {
                thePlayer.SetActive(true);
                invMenu.SetActive(false);
                //Cursor.visible = false;
                invOpen = false;
                Time.timeScale = 1;
            }
        }
    }
    /*public void ShowItem()
    {
        itemPanel.SetActive(true);
        questPanel.SetActive(false);
        statsPanel.SetActive(false);
    }
    public void ShowQuest()
    {
        itemPanel.SetActive(false);
        questPanel.SetActive(true);
        statsPanel.SetActive(false);
    }
    public void ShowStats()
    {
        itemPanel.SetActive(false);
        questPanel.SetActive(false);
        statsPanel.SetActive(true);
    }
    public void CloseMenu()
    {
        thePlayer.SetActive(true);
        invMenu.SetActive(false);
        //Cursor.visible = false;
        invOpen = false;
        Time.timeScale = 1;
    }*/
}