using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestOBJ01 : MonoBehaviour
{
    public GameObject theObjective;
    public int CloseObjective;

    private void Update()
    {
        if (CloseObjective == 1)
        {
            CloseObjective = 0;
            theObjective.SetActive(false);
        }
        else
        {
            theObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //QuestManager.SubQuestNumber = 2;
        //GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(FinishObjective());
    }
    IEnumerator FinishObjective()
    {
        theObjective.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        CloseObjective = 1; 
    }
}
