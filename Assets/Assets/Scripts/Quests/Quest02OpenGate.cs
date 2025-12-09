using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest02OpenGate : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject leftGate;
	public GameObject rightGate;
	public GameObject spider;
	public GameObject bossSpider;
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}
	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			AttackBlock.blockSword = 1;
			ActionText.GetComponent<Text>().text = "Open Gate";
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				GetComponent<BoxCollider>().enabled = false;
				AttackBlock.blockSword = 2;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ActionText.GetComponent<Text>().text = "";
				leftGate.GetComponent<Animation>().Play("FenceDoorLeft"); //Namnet på din anim
				rightGate.GetComponent<Animation>().Play("FenceDoorRight"); //Namnet på din anim
				spider.SetActive(true);
				bossSpider.SetActive(true);
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
