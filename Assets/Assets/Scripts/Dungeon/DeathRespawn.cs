using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRespawn: MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject thePlayer;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            thePlayer.transform.position = new Vector3(-22, -15, 12); //playerns respawn pos, dubbelkolla i din scen vilka korinater du vill att den ska hamna på
            fadeIn.GetComponent<Animation>().Play("FadeInScreen");
        }
    }
}