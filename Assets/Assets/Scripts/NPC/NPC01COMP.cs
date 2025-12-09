using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC01COMP : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject NPCName;
	public GameObject NPCText;
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}
	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			AttackBlock.blockSword = 1;
			ActionText.GetComponent<Text>().text = "Talk";
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
				//ThePlayer.SetActive (false);
				StartCoroutine(NPC01Active());
			}
		}
	}
	void OnMouseExit()
	{
		AttackBlock.blockSword = 0;
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}
	IEnumerator NPC01Active()
	{
		TextBox.SetActive(true); //Temporär ta bort
		yield return new WaitForSeconds(5.5f);  //Temporär ta bort
		TextBox.SetActive(false);  //Temporär ta bort
		/*if (QuestManager.ActiveQuestNumber == 2 && QuestManager.SubQuestNumber ==4)
		{
			TextBox.SetActive(true);
			NPCName.GetComponent<Text>().text = "Gladis";
			NPCName.SetActive(true);
			NPCText.GetComponent<Text>().text = "Thank you very much for your help. There is a cave outside village, please go explore";
			//Cave object set here
			QuestManager.ActiveQuestNumber = 3;
			QuestManager.SubQuestNumber = 1;
			NPCText.SetActive(true);
			yield return new WaitForSeconds(5.5f);
			NPCName.SetActive(false);
			NPCText.SetActive(false);
			TextBox.SetActive(false);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		else
		{
			TextBox.SetActive(true);
			NPCName.GetComponent<Text>().text = "Gladis";
			NPCName.SetActive(true);
			NPCText.GetComponent<Text>().text = "Plz come and see me when you have explored the cave";
			NPCText.SetActive(true);
			yield return new WaitForSeconds(5.5f);
			NPCName.SetActive(false);
			NPCText.SetActive(false);
			TextBox.SetActive(false);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}*/
	}
}
