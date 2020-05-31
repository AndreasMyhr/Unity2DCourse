using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class NumberWizard : MonoBehaviour{
    int max = 1000;
        int min = 1;
        int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        StartGame();

    }

    void StartGame()
    {
         max = 1000;
         min = 1;
        guess = 500;
        
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Welcome");
        Debug.Log("Pick a number");
        Debug.Log("Highest Number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + 500);
        Debug.Log("Push up higher, down=lower, push enter=Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            nextGuess();
        }


        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I won");
            StartGame();
        }
    }
    void nextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than...." + guess);
    }
    
}
