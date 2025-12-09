using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestButton01 : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject noticeCam;
    public GameObject UIQuest;
    public GameObject activateQuestBox;
    public GameObject objectiv01;
    public GameObject objectiv02;
    public GameObject objectiv03;
    /*public GameObject exMark;
    public GameObject theNotice;
    public GameObject noticeTrigger;
    public GameObject miniMap;*/

    public void acceptQuest()
    {
        //miniMap.SetActive(true);
        //QuestManager.SubQuestNumber = 1;
        thePlayer.SetActive(true);
        noticeCam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }
    IEnumerator SetQuestUI()
    {
        //exMark.SetActive(false);
        //theNotice.SetActive(false); 
        //noticeTrigger.SetActive(false);
        activateQuestBox.GetComponent<Text>().text = "My First Weapon";
        objectiv01.GetComponent<Text>().text = "Reach the clearing in the woods";
        objectiv02.GetComponent<Text>().text = "Open the chest";
        objectiv03.GetComponent<Text>().text = "Retrieve the weapon";
        QuestManager.ActiveQuestNumber = 1;
        yield return new WaitForSeconds(0.5f);
        activateQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        objectiv01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        objectiv02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        objectiv03.SetActive(true);
        yield return new WaitForSeconds(9);
        activateQuestBox.SetActive(false);
        objectiv01.SetActive(false);
        objectiv02.SetActive(false);
        objectiv03.SetActive(false);
    }
    public void DeclineQuest()
    {
        //miniMap.SetActive(true);
        thePlayer.SetActive(true);
        noticeCam.SetActive(false);
        UIQuest.SetActive(false);
    }
}
