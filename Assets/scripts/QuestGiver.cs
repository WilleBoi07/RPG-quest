using UnityEngine;
using Game.Quests;

public class QuestGiver : MonoBehaviour
{
    public FetchQuest quest;
    public QuestManager questManager;

    bool playerInRange = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("[QuestGiver] Player entered range");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("[QuestGiver] Player left range");
        }
    }

    void Update()
    {
        if (!playerInRange) return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("[QuestGiver] E pressed");

            if (!quest.isAccepted)
            {
                questManager.AcceptQuest(quest);
            }
            else
            {
                Debug.Log("[QuestGiver] Quest already accepted");
            }
        }
    }

}
