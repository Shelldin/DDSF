using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabActivate : MonoBehaviour
{
    public InputField [] inputFields;


    private void FixedUpdate()
    {
        if (Input.GetKeyDown("tab") && inputFields[1].IsActive())
        {
            inputFields[2].ActivateInputField();
        }
        
        if (Input.GetKeyDown("tab") && inputFields[0].IsActive())
        {
            inputFields[1].ActivateInputField();
        }
        
        
    }
}
