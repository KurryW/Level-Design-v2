using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject UIButton;

    public Collider ColliderQuest;

    public Camera CameraQuest;

    public GameObject Player;
    public GameObject UIDialogue;

    private void OnTriggerEnter(Collider ColliderQuest)
    {
        UIButton.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CameraQuest.depth = 3;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            UIDialogue.SetActive(true);
            UIButton.SetActive(false);
            Player.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider ColliderQuest) 
    {
        UIButton.SetActive(false);
    }
    public void TriggerDialogue()
    {
        //Destroy(gameObject);
    }
}
