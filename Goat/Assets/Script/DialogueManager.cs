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

    public Animator anim;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        anim.SetBool("IsOpen", true);

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
            if(FindObjectOfType<State>().angryLv >= 1 && tempDialogue.aggresiveChoices != null)
            {
                tempDialogue.aggresiveChoices.SetActive(true);
            }
            anim.SetBool("IsOpen", false);
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
            if (tempDialogue.aggresiveChoices != null)
            {
                tempDialogue.aggresiveChoices.SetActive(false);
            }
        }
    }
}
