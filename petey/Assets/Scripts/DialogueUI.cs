using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    private TextMeshProUGUI dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        dialogueText = GameObject.Find("DialogueLineText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public void ChangeNameTag()
    {

    }
}
