using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingAxe : MonoBehaviour
{
    public GameObject theAxe;
    public int axeStatus;

    private void Update()
    {
        if (Input.GetButton("Fire1") && axeStatus == 0) //&& AttackBlock.blockSword == 0)
        {
            StartCoroutine(SwingAxeFunction());
        }
    }
    IEnumerator SwingAxeFunction()
    {
        axeStatus = 1;
        theAxe.GetComponent<Animation>().Play("AxeAnim"); //Namnet på din animation
        axeStatus = 2;
        yield return new WaitForSeconds(1.0f);
        axeStatus = 0;
    }
}
