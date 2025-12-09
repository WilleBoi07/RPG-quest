using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest02 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    void Update()
    {
        TheDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionText.GetComponent<Text>().text = "Open Gate";
            AttackBlock.blockSword = 1;
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                AttackBlock.blockSword = 2;
                Screen.lockCursor = false;
                Cursor.visible = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        AttackBlock.blockSword = 0;
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}