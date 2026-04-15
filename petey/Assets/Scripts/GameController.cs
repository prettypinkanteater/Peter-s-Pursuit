using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPC
{
    Narrator, ExasperatedA, Peter
}
public class GameController : MonoBehaviour
{
    public NPC npcTalking;
    // Start is called before the first frame update
    void Start()
    {
        npcTalking = NPC.Narrator;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
