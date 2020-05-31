using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent; //Ved å bruke serializeField 
    
    void Start()
    {
        textComponent.text = "You wake up in a new room \n Your are all alone \n What has happened";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
