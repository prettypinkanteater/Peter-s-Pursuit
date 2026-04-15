using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    private DialogueNodeSc _currentNode;
    [SerializeField] public DialogueNodeSc _startingNode;
    private int _currentLine = 0;
    private DialogueUI _dialogueUI;
    private bool resetNode;
    void Start()
    {
        _dialogueUI = GameObject.Find("DialogueUI").GetComponent<DialogueUI>();
        _currentNode = _startingNode;
        _dialogueUI.ShowDialogue(_currentNode._lines[_currentLine]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || (Input.GetKeyDown(KeyCode.Space)))
        {
            AdvanceDialogue();
        }

        _dialogueUI.npcNameUI.text = _currentNode.dialogueSpeaker.ToString();
    }

    private void AdvanceDialogue()
    {
        Debug.Log(_currentLine.ToString());

        if (_currentLine < _currentNode._lines.Length)
        {
            _dialogueUI.ShowDialogue(_currentNode._lines[_currentLine]);
            _currentLine++;
        }
        else if (_currentLine == _currentNode._lines.Length)
        { 
            if(_currentNode._playerReplyOptions.Length > 0)
            {

            }

            Debug.Log("switch node");
            
                _currentNode = _currentNode._npcReplies[0];
                _currentNode.ChangeState();
                _dialogueUI.ShowDialogue(_currentNode._lines[0]);
                _dialogueUI.ChangeNameTag(_currentNode.dialogueSpeaker);

                _currentLine = 1;  
        }
            
    }
}
