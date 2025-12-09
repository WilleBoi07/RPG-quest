using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest02Complete : MonoBehaviour
{
	public float theDistance;
	public GameObject actionDisplay;
	public GameObject actionText;
	public GameObject uIQuest;
	public GameObject thePlayer;
	public GameObject exMark;
	public GameObject completeTrigger;
	void Update()
	{
		theDistance = PlayerCasting.distanceFromTarget;
	}
	void OnMouseOver()
	{
		if (theDistance <= 3)
		{
			actionDisplay.SetActive(true);
			actionText.SetActive(true);
			actionText.GetComponent<Text>().text = "Complete Quest";
		}
		if (Input.GetButtonDown("Action"))
		{
			if (theDistance <= 3)
			{
				//GlobalGold.GoldAmount += 100;
				//QuestManager.SubQuestNumber = 0;
				//PlayerPrefs.SetInt("GoldAmountSave", GlobalGold.GoldAmount);
				//QuestManager.ActiveQuestNumber = 2;
				exMark.SetActive(false);
				GlobalXP.currentXP += 100;
				actionDisplay.SetActive(false);
				actionText.SetActive(false);
				completeTrigger.SetActive(false);
			}
		}
	}
	void OnMouseExit()
	{
		actionDisplay.SetActive(false);
		actionText.SetActive(false);
	}
}