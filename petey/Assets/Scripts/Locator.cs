using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }

    public GameController controller { get; private set; }
    // Start is called before the first frame update

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
