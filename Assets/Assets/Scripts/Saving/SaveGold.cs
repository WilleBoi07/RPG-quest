using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGold : MonoBehaviour
{
    public int loadGold; 
    void Start()
    {
        loadGold = PlayerPrefs.GetInt("GoldAmountSaveD");
    }
}
