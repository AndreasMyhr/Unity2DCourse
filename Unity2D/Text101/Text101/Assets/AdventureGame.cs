using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent; //Ved å bruke serializeField 
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
        
    }
}
