using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestOBJ03 : MonoBehaviour
{
	public float TheDistance;
	public GameObject FakeAxe;
	public GameObject RealAxe;
	public GameObject ActionText;
	public GameObject ActionDisplay;
	public GameObject TheObjective;
	public int CloseObjective;
	public GameObject ChestBlock;
	//public GameObject exMark;
	//public GameObject questComplete;
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;

		if (CloseObjective == 3)
		{
			//if (TheObjective.transform.localScale.y <= 0.0f)
			//{
				//CloseObjective = 0;
				TheObjective.SetActive(false);
			//}
			/*else
			{
				TheObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
			}*/
		}
	}
	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			ActionText.GetComponent<Text>().text = "Take Axe";
			ActionText.SetActive(true);
			ActionDisplay.SetActive(true);
		}

		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				//QuestManager.SubQuestNumber = 3;
				this.GetComponent<BoxCollider>().enabled = false;
				FakeAxe.SetActive(false);
				RealAxe.SetActive(true);
				ChestBlock.SetActive(true);
				CloseObjective = 3;
				ActionText.SetActive(false);
				ActionDisplay.SetActive(false);
				//exMark.SetActive(true);
				//questComplete.SetActive (true);

			}
		}
	}
	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}
}
