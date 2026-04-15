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

    // Start is called before the first frame update
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

        if (resetNode)
        {
            _dialogueUI.ShowDialogue(_currentNode._lines[0]);
            resetNode = false;
        }

        _dialogueUI.npcNameUI.text = _currentNode.dialogueSpeaker.ToString();
    }

    private void AdvanceDialogue()
    {
        if (_currentLine < _currentNode._lines.Length)
        {
            _dialogueUI.ShowDialogue(_currentNode._lines[_currentLine]);
            _currentLine++;
        }
        else if (_currentLine == _currentNode._lines.Length)
        {
            Debug.Log("switch node");
            if (_currentNode.playerResponseNeeded == false)
            {
                _currentNode = _currentNode._npcReplies[0];
                resetNode = true;
            }
            
        }
        else if (_currentNode.playerResponseNeeded)
        {
            Debug.Log("response needed");
        }
            
                
    }
}
