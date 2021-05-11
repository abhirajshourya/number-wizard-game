using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard Console.");
        Debug.Log("Pick a Number: ");
        Debug.Log("Range: " + min + "-" + max);
        Debug.Log("Specify if your number is greater, lower or eual to "+guess);
        Debug.Log("Push Up- Greater, Down- Lower or Enter- Equal");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow Key was pressed.");
            min=guess;
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow Key was pressed.");
            max=guess;
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter Key was pressed.");
            Debug.Log(guess);
        }
    }
}
