using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXP : MonoBehaviour
{
	public static int currentXP;
	public int internalXP;
	//public float healthBarPos;
	//public float xPos;
	//public GameObject xpBar;
	void Update()
	{
		internalXP = currentXP;
		//xPos = internalXP / 2;
		//xpBar.GetComponent<RectTransform>().sizeDelta = new Vector2(internalXP, 30);
		//xpBar.transform.position = new Vector2(healthBarPos + xPos - 10, 411);
	}
}
