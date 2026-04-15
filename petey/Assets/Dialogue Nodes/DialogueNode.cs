using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DialogueNodeSc", menuName = "ScriptableObjects/DialogueNodeSc", order = 1)]

public class DialogueNodeSc : ScriptableObject
{
    public bool playerResponseNeeded;
    public NPC dialogueSpeaker;
    public string[] _lines;
    public string[] _playerReplyOptions;
    public DialogueNodeSc[] _npcReplies;
}
