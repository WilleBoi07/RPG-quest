using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalkAI : MonoBehaviour
{
    public int xPos;
    public int zPos;
    public GameObject NPCDest;
    void Start()
    {
        xPos = Random.Range(100, 125);//placera en kub i världen och kolla vilket "tal" dom den har i den riktningen som den får gå
        zPos = Random.Range(60, 100); //Skriv även det minsta värdet först och det största värdet sist
        NPCDest.transform.position = new Vector3(xPos, 0, zPos);
        StartCoroutine(RunRandomWalk());
    }
    void Update()
    {
        transform.LookAt(NPCDest.transform);
        transform.position = Vector3.MoveTowards(transform.position, NPCDest.transform.position, 0.05f * Time.timeScale); //justera speed efter önskemål
    }
    IEnumerator RunRandomWalk()
    {
        yield return new WaitForSeconds(5);
        xPos = Random.Range(100, 125);
        zPos = Random.Range(60, 100);
        NPCDest.transform.position = new Vector3(xPos, 0, zPos);
        StartCoroutine(RunRandomWalk());
    }
}
