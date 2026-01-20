using UnityEngine;

namespace Game.Quests
{
    public class QuestManager : MonoBehaviour
    {
        public FetchQuest currentQuest;
        public bool questAccepted = false;
        public bool itemCollected = false;   // New: track if item is picked up
        public bool questCompleted = false;
        public int playerGold = 0;

        void Start()
        {
            Debug.Log("[QuestManager] Initialized on player");
            currentQuest = null;
            questAccepted = false;
            itemCollected = false;
            questCompleted = false;
        }

        public void AcceptQuest(FetchQuest quest)
        {
            if (quest == null)
            {
                Debug.LogError("[QuestManager] Quest is NULL");
                return;
            }

            if (currentQuest != null && questAccepted)
            {
                Debug.LogWarning("[QuestManager] Player already has a quest");
                return;
            }

            currentQuest = quest;
            questAccepted = true;
            itemCollected = false;
            questCompleted = false;

            Debug.Log("[QuestManager] Quest accepted: " + quest.questName);
        }

        // Called by QuestItem
        public void CollectItem()
        {
            if (!questAccepted || currentQuest == null) return;

            itemCollected = true;
            Debug.Log("[QuestManager] Quest item collected");
        }

        // Called by NPC when returning
        public void CompleteQuest()
        {
            if (!questAccepted || currentQuest == null)
            {
                Debug.LogError("[QuestManager] No active quest to complete");
                return;
            }

            if (!itemCollected)
            {
                Debug.LogWarning("[QuestManager] Player must collect the item first!");
                return;
            }

            questCompleted = true;
            playerGold += currentQuest.rewardGold;

            Debug.Log($"[QuestManager] Quest completed! Gold now: {playerGold}");

            // Reset quest state
            currentQuest = null;
            questAccepted = false;
            itemCollected = false;
            questCompleted = false;
        }
    }
}
