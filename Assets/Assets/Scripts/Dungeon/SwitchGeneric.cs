using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchGeneric : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject theLever;
	void Update()
	{
		TheDistance = PlayerCasting.distanceFromTarget;
	}
	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			ActionText.GetComponent<Text>().text = "Pull Lever";
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				this.gameObject.GetComponent<BoxCollider>().enabled = false;
				theLever.GetComponent<Animator>().enabled = true;
			}
		}
	}
	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}
}
