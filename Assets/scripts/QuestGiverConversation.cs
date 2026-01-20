using UnityEngine;
using Game.Quests;

public class QuestGiverConversation : MonoBehaviour
{
    [TextArea(3, 6)]
    public string npcDialogue;

    public FetchQuest quest;
    public QuestManager questManager;
    public DialogueUI dialogueUI;

    bool questReadyToTurnIn = false;
    bool playerInRange = false;
    PlayerInteraction playerInteraction;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        playerInRange = true;
        playerInteraction = other.GetComponent<PlayerInteraction>();

        Debug.Log("[NPC] Player in range");
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        playerInRange = false;
        EndConversation();
    }

    void Update()
    {
        if (!playerInRange) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (questManager != null
                && questManager.currentQuest == quest
                && questManager.itemCollected)
            {
                // Player has collected the item
                questReadyToTurnIn = true;
                ReturnForReward();
            }
            else
            {
                StartConversation();
            }
        }
    }


    void StartConversation()
    {
        if (questManager != null
            && questManager.currentQuest == quest
            && questManager.itemCollected)
        {
            // Player has collected item, should see reward button instead of Accept/Decline
            ReturnForReward();
            return;
        }

        playerInteraction?.EnterConversation();
        dialogueUI.Show(npcDialogue, this);

        Debug.Log("[NPC] Conversation started");
    }



    public void AcceptQuestFromUI()
    {
        Debug.Log("[NPC] Quest accepted via UI");
        questManager.AcceptQuest(quest);
        EndConversation();
    }

    public void DeclineQuestFromUI()
    {
        Debug.Log("[NPC] Quest declined");

        // Clear the quest from QuestManager if it's this quest
        if (questManager != null && questManager.currentQuest == quest)
        {
            questManager.currentQuest = null;
            questManager.questAccepted = false;
            questManager.itemCollected = false;
            questManager.questCompleted = false;
        }

        EndConversation();
    }

    // NEW: Called when player returns after collecting item
    public void ReturnForReward()
    {
        if (questManager == null || questManager.currentQuest != quest)
        {
            Debug.Log("[NPC] Player has no active quest");
            return;
        }

        if (!questManager.itemCollected)
        {
            dialogueUI.Show("You haven't collected the item yet!", this);
            return;
        }

        // Complete the quest
        questManager.CompleteQuest();
        Debug.Log("[NPC] Quest reward granted");

        // Show thank you dialogue with reward button
        dialogueUI.ShowReward("Thank you for returning with the item! Here's your reward.", this);
        playerInteraction?.EnterConversation();

    }




    void EndConversation()
    {
        dialogueUI.Hide();
        playerInteraction?.ExitConversation();
        Debug.Log("[NPC] Conversation ended");
    }

    public void EndConversationFromUI()
    {
        EndConversation();
    }

}
