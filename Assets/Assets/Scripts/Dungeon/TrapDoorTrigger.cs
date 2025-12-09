using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorTrigger : MonoBehaviour
{
    public GameObject trapDoor;
    void OnTriggerEnter(Collider other)
    {
        trapDoor.GetComponent<Animator>().enabled = true;
    }
}
