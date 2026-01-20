using UnityEngine;
using Game.Quests;

public class QuestItem : MonoBehaviour
{
    public FetchQuest requiredQuest;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        QuestManager questManager = other.GetComponent<QuestManager>();
        if (questManager == null) return;

        if (questManager.currentQuest != requiredQuest || !questManager.questAccepted)
        {
            Debug.Log("[QuestItem] Player cannot pick up this item (quest not accepted)");
            return;
        }

        // Mark item as collected instead of completing quest
        questManager.CollectItem();
        Debug.Log("[QuestItem] Quest item collected");

        Destroy(gameObject);
    }
}
