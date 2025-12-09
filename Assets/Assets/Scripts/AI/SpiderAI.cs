using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 40; // Hur nära spelare måste vara för att den ska börja jaga
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;

    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance <= AllowedRange)
            {
                EnemySpeed = 0.05f;
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("idle");
            }
        }
        if (AttackTrigger == 1)
        {
            EnemySpeed = 0;
            TheEnemy.GetComponent<Animation>().Play("attack");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AttackTrigger = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        AttackTrigger = 0;
    }

    /* IEnumerator TakingDamage()
    {
        dealingDamage = 2;
        yield return new WaitForSeconds(0.5f);
        if (SpiderEnemy.globalSpider != 6)
        {
            HeartUI.healthValue -= 10;
        }
        yield return new WaitForSeconds(0.4f);
        dealingDamage = 0;
    } */
}