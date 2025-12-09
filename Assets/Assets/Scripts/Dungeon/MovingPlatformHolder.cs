using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovingPlatformHolder : MonoBehaviour
{
    public GameObject thePlatform;
    public GameObject thePlayer;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            thePlayer.transform.parent = thePlatform.transform;
        }
    }
    void OnTriggerExit(Collider other) //Om vi inte har en ontriggerexit så rör vi oss fortfarande med platformen även om vi kliver av
    {
        if (other.tag == "Player")
        {
            thePlayer.transform.parent = null;
        }
    }
}