using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBoss : MonoBehaviour
{
	public int EnemyHealth = 20;
	public GameObject theSpider;
	public int spiderStatus;
	public int baseXP;
	public int calculatedXP;
	public SpiderBossAI spiderAIscript;
	public static int globalSpider;
	public GameObject oldNPC;
	public GameObject newNPC;
	public SpiderBossAttack spiderBossAttack;

	private void Start()
	{
		spiderAIscript = GetComponent<SpiderBossAI>();
		spiderBossAttack = GetComponent<SpiderBossAttack>();
	}
	void DeductPoints(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
	}
	void Update()
	{
		globalSpider = spiderStatus;
		if (EnemyHealth <= 0)
		{
			if (spiderStatus == 0)
			{
				StartCoroutine(DeathSpider());
			}
		}
	}
	IEnumerator DeathSpider()
	{
		spiderAIscript.enabled = false;
		spiderBossAttack.enabled = false;
		spiderStatus = 6;
		calculatedXP = baseXP * GlobalLevel.CurrentLevel;
		GlobalXP.currentXP += calculatedXP;
		yield return new WaitForSeconds(0.5f);
		theSpider.GetComponent<Animation>().Play("die");
		oldNPC.SetActive(false);
		newNPC.SetActive(true);
		//QuestManager.SubQuestNumber = 4;
	}
}
