using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPC
{
    Narrator, ExasperatedA, Peter
}

public enum States
{
    Tea, Dialogue
}

public class GameController : MonoBehaviour
{
    public NPC npcTalking;
    public States gameState;
    // Start is called before the first frame update
    void Start()
    {
        npcTalking = NPC.Narrator;
        gameState = States.Dialogue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
