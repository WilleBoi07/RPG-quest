using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC01 : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject NPCName;
	public GameObject NPCText;
	//public GameObject gateOpen;
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
				//Screen.lockCursor = false;
				Cursor.visible = true;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ThePlayer.SetActive (false);
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
		TextBox.SetActive(true); //Temporär, ta bort sen när questet är klart. 
		yield return new WaitForSeconds(2);  //Temporär, ta bort sen när questet är klart. 
		TextBox.SetActive(false);  //Temporär, ta bort sen när questet är klart. 


		/*if (QuestManager.ActiveQuestNumber == 2)
		{
			TextBox.SetActive(true);
			NPCName.GetComponent<Text>().text = "Gladis";
			NPCName.SetActive(true);
			NPCText.GetComponent<Text>().text = "We have a spider problem, Can you kill the spiders and their boss? Here is the key.";
			gateOpen.SetActive(true);
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
			NPCText.GetComponent<Text>().text = "Hello friend, that spider bit me. I'm not feeling so good";
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
