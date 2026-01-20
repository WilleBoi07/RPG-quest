using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Game.Quests;

public class DialogueUI : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI dialogueText;
    public Button acceptButton;
    public Button declineButton;
    public Button rewardButton;  // NEW

    QuestGiverConversation activeNPC;

    void Start()
    {
        panel.SetActive(false);

        acceptButton.onClick.AddListener(AcceptQuest);
        declineButton.onClick.AddListener(DeclineQuest);
        rewardButton.onClick.AddListener(() =>
        {
            if (activeNPC != null)
                activeNPC.EndConversationFromUI();
        });

    }


    public void Show(string text, QuestGiverConversation npc)
    {
        activeNPC = npc;
        dialogueText.text = text;
        panel.SetActive(true);

        // Normal quest dialogue: show Accept/Decline, hide Reward
        acceptButton.gameObject.SetActive(true);
        declineButton.gameObject.SetActive(true);
        rewardButton.gameObject.SetActive(false);
    }


    void AcceptQuest()
    {
        activeNPC.AcceptQuestFromUI();
        Hide();
    }

    public void ShowReward(string text, QuestGiverConversation npc)
    {
        activeNPC = npc; // Set the NPC so reward button can call EndConversation
        dialogueText.text = text;
        panel.SetActive(true);

        // Hide accept/decline buttons
        acceptButton.gameObject.SetActive(false);
        declineButton.gameObject.SetActive(false);

        // Show reward button only
        rewardButton.gameObject.SetActive(true);
    }




    void DeclineQuest()
    {
        activeNPC.DeclineQuestFromUI();
        Hide();
    }

    public void Hide()
    {
        panel.SetActive(false);
        acceptButton.gameObject.SetActive(true);
        declineButton.gameObject.SetActive(true);
        rewardButton.gameObject.SetActive(false); // reset
    }


}
