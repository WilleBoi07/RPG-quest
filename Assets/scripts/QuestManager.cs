using UnityEngine;

namespace Game.Quests
{
    public class QuestManager : MonoBehaviour
    {
        public FetchQuest currentQuest;
        public int playerGold = 0;

        void Start()
        {
            Debug.Log("[QuestManager] Initialized on player");
            if (currentQuest != null)
            {
                currentQuest.isAccepted = false;
                currentQuest.isCompleted = false;
            }
        }

        public void AcceptQuest(FetchQuest quest)
        {
            Debug.Log("[QuestManager] AcceptQuest() called");

            if (quest == null)
            {
                Debug.LogError("[QuestManager] Quest is NULL");
                return;
            }

            if (currentQuest != null)
            {
                Debug.LogWarning("[QuestManager] Player already has a quest");
                return;
            }

            currentQuest = quest;
            quest.isAccepted = true;

            Debug.Log("[QuestManager] Quest accepted: " + quest.questName);
        }

        public void CompleteQuest()
        {
            Debug.Log("[QuestManager] CompleteQuest() called");

            if (currentQuest == null)
            {
                Debug.LogError("[QuestManager] No active quest to complete");
                return;
            }

            currentQuest.isCompleted = true;
            playerGold += currentQuest.rewardGold;

            Debug.Log($"[QuestManager] Quest completed! Gold now: {playerGold}");

            currentQuest = null;
        }
    }
}
