using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    private DialogueNodeSc _currentNode;
    [SerializeField] public DialogueNodeSc _startingNode;
    private int _currentLine = 0;
    private DialogueUI _dialogueUI;

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
    }

    private void AdvanceDialogue()
    {
        if (_currentLine < _currentNode._lines.Length)
        {
            _dialogueUI.ShowDialogue(_currentNode._lines[_currentLine]);
            _currentLine++;
        } 
    }
}
