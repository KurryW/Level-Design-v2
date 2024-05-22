using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI DialogueText;

    private Queue<string> sentences;

    DialogueTrigger DialogueTrigger;
    public GameObject UIDialogue;

    public GameObject ChoosePartsUI;

    public Animator AnimatorQuest;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        AnimatorQuest.SetBool("Talk", true);

        string sentence = sentences.Dequeue();
        DialogueText.text = sentence;
    }

    void EndDialogue()
    {
        AnimatorQuest.SetBool("Talk", false);
        UIDialogue.SetActive(false);
        ChoosePartsUI.SetActive(true);
        Debug.Log("End of conversation");
    }
    
}
