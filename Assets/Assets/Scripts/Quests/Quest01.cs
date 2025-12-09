using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest01 : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject thePlayer;
    public GameObject noticeCam;
    //public GameObject miniMap;
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }
    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            //AttackBlock.blockSword = 1;
            actionKey.SetActive(true);
            actionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                //miniMap.SetActive(false);
                //AttackBlock.blockSword = 2; 
                actionKey.SetActive(false);
                actionText.SetActive(false);
                UIQuest.SetActive(true);
                noticeCam.SetActive(true);
                thePlayer.SetActive(false);
                //MasterQuest.mainQuestName = "Find the Axe";
                //MasterQuest.mainQuestInfo = "I have to find the axe which is said to be inside a chest not too deep in the forest. The reward for this seems to be 100 Gold";
            }
        }
    }
    void OnMouseExit()
    {
        //AttackBlock.blockSword = 0;
        actionKey.SetActive(false);
        actionText.SetActive(false);
    }
}
