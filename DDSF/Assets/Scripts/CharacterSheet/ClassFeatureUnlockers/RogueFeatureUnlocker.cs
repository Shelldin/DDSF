﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RogueFeatureUnlocker : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField expInputField;
    public Dropdown subClassDropdown;
    

    private void Start()
    {
        expInputField.onEndEdit.AddListener(UnlockFeaturesOnLevelUp);
    }

    private void UnlockFeaturesOnLevelUp(string playerInput)
    {
        UnlockSubClassDropdown();
    }

    private void UnlockSubClassDropdown()
    {
        
        
        if (charSheet.level>=3 && charSheet.classMenuDropdownValue ==10)
        {
            subClassDropdown.interactable = true;
        }
        else
        { 
            subClassDropdown.interactable = false;
        }
    }
}
