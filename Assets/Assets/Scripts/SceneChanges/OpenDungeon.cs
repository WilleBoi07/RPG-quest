using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenDungeon : MonoBehaviour
{
    public float theDistance;
    public GameObject actionKey;
    public GameObject actionText;
    public GameObject thePlayer;
    //public GameObject fadeOut;
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }
    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            actionText.GetComponent<Text>().text = "Enter Dungeon";
            actionKey.SetActive(true);
            actionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                actionKey.SetActive(false);
                actionText.SetActive(false);
                thePlayer.SetActive(false);
                //fadeOut.SetActive(true);
                //StartCoroutine(TransferScen());
            }
        }
    }
    void OnMouseExit()
    {
        actionKey.SetActive(false);
        actionText.SetActive(false);
    }
    /*IEnumerator TransferScen()
    {
        actionKey.SetActive(false);
        actionText.SetActive(false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
        thePlayer.SetActive(false);
    }*/
}
