﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DruidFeatureUnlocker : MonoBehaviour
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
        if (charSheet.level>=2 && charSheet.classMenuDropdownValue ==5)
        {
            subClassDropdown.interactable = true;
        }
        else
        { 
            subClassDropdown.interactable = false;
        }
    }
}
