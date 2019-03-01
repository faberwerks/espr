using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;
    private Dialogue tempDialogue;
    
    public Text nameNPC;
    public Text dialogueText;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        tempDialogue = dialogue;
        nameNPC.text = dialogue.nameNPC;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentences();
    }

    public void DisplayNextSentences()
    {
        if(sentences.Count == 0)
        {
            foreach (GameObject choices in tempDialogue.choices)
            {
                choices.SetActive(true);
            }
            return;
        }

        
        string sentence =  sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void DeleteChoices()
    {

        if (tempDialogue != null)
        {
            foreach (GameObject choices in tempDialogue.choices)
            {
                choices.SetActive(false);
            }
        }
    }
}
