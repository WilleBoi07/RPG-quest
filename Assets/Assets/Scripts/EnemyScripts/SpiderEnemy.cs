using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
	public int EnemyHealth = 10;
	/*public GameObject theSpider;
	public int spiderStatus;
	public int baseXP;
	public int calculatedXP;
	public SpiderAI spiderAIscript;
	public static int globalSpider;
	private void Start()
	{
		spiderAIscript = GetComponent<SpiderAI>();
	}*/
	void DeductPoints(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
	}
	/*void Update()
	{
		globalSpider = spiderStatus;
		if (EnemyHealth <= 0)
		{
			if (spiderStatus == 0)
			{
				StartCoroutine(DeathSpider());
			}
		}
	}*/
	IEnumerator DeathSpider()
	{
		/*spiderAIscript.enabled = false;
		spiderStatus = 6;
		calculatedXP = baseXP * GlobalLevel.CurrentLevel;
		GlobalXP.currentXP += calculatedXP;*/
		yield return new WaitForSeconds(0.5f);
		Destroy(gameObject);
		//theSpider.GetComponent<Animation>().Play("die");
	}
}
