using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool inConversation = false;

    public void EnterConversation()
    {
        inConversation = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("[Player] Entered conversation mode");
    }

    public void ExitConversation()
    {
        inConversation = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Debug.Log("[Player] Exited conversation mode");
    }
}
