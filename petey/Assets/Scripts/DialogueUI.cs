using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    private TextMeshProUGUI dialogueText;
    public TextMeshProUGUI npcNameUI;
    public Button option1;
    public Button option2;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogueText = GameObject.Find("DialogueLineText").GetComponent<TextMeshProUGUI>();
        npcNameUI = GameObject.Find("CharacterNameText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public void ChangeNameTag(Enum npcName)
    {
        Debug.Log("Changing name display");
        npcNameUI.text = npcName.ToString();
    }

    public void ChangeDialogueUIState(Enum gameState)
    {

    }

    public void ShowPlayerOptions()
    {

    }
}
