using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabActivate : MonoBehaviour
{
    public InputField [] inputFields;


    private void Update()
    {
        if (Input.GetKeyUp("tab") && inputFields[0].isFocused)
        {
            inputFields[1].ActivateInputField();
        }
        
        if (Input.GetKeyUp("tab") && inputFields[1].isFocused)
        {
            inputFields[2].ActivateInputField();
        }
        
        if (Input.GetKeyUp("tab") && inputFields[2].isFocused)
        {
            inputFields[0].ActivateInputField();
        }
    }
}
