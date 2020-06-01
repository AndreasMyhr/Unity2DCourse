using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent; //Ved å bruke serializeField betyr det at vi kan tyde komponentene i Unity
    [SerializeField] State startingstate;

    State state;

    void Start()
    {
        state = startingstate;
        textComponent.text = state.GetStateStory();
    }
    // Update is called once per frame
    void Update()
    {
        ManageState();
        
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}
