using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    private TextMeshProUGUI dialogueText;
    public TextMeshProUGUI npcNameUI;
    // Start is called before the first frame update
    void Start()
    {
        dialogueText = GameObject.Find("DialogueLineText").GetComponent<TextMeshProUGUI>();
        npcNameUI = GameObject.Find("CharacterNameText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeNameTag(Locator.Instance.controller.npcTalking);
    }

    public void ShowDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public void ChangeNameTag(Enum npcName)
    {
        npcNameUI.text = npcName.ToString();
    }
}
