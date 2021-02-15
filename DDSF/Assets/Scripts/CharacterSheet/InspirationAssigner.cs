using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspirationAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inspirationInputField;

    private void Start()
    {
        inspirationInputField.onEndEdit.AddListener(AssignInspiration);
    }

    private void AssignInspiration(string playerInput)
    {
        charSheet.inspiration = int.Parse(playerInput);
    }
    
    
}
