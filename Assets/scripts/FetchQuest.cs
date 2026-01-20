using UnityEngine;

[CreateAssetMenu(menuName = "Quest/Fetch Quest")]
public class FetchQuest : ScriptableObject
{
    public string questName;
    public bool isAccepted;
    public bool isCompleted;

    public int rewardGold = 50;
}
