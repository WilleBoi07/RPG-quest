using UnityEngine;
using Game.Quests;

public class QuestItem : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("[QuestItem] Trigger entered by: " + other.name);

        if (!other.CompareTag("Player")) return;

        QuestManager questManager = other.GetComponent<QuestManager>();

        if (questManager == null)
        {
            Debug.LogError("[QuestItem] Player has no QuestManager");
            return;
        }

        if (questManager.currentQuest == null)
        {
            Debug.LogWarning("[QuestItem] Player has no active quest");
            return;
        }

        Debug.Log("[QuestItem] Quest item collected");

        questManager.CompleteQuest();
        Destroy(gameObject);
    }
}
