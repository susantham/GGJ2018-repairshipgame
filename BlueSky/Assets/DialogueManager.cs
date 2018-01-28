using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public AudioSource continueBeep = null;
    public Text nameText;
    public Text dialogueText;

    //public Animator animator;

    public Queue<string> sentences;

	// Use this for initialization
	void Start ()
    {
        sentences = new Queue<string>();

	}

    public void StartDialogue(Dialogue dialogue)
    {
       //animator.SetBool("IsOpen", true);


        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            //Debug.Log(sentence.Length.ToString() + " " + sentence.ToString());
            sentences.Enqueue(sentence);
            //Debug.Log(sentence.Length.ToString() + " " + sentence.ToString());
            //nameText.text = sentence.Length.ToString() + " " + sentence.ToString();
            //sentences.Enqueue(sentence);
            //sentences.Enqueue("Fighto!");
            //Debug.Log(sentence.Length.ToString() + " " + sentence.ToString());



        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        continueBeep.Play();

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
      // animator.SetBool("IsOpen", false);

    }

}
