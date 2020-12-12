using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignCharacterName : MonoBehaviour
{
    public InputField characterNameField;
    public CharacterSheetSO charSheet;
    
    private void Start()
    {
        characterNameField.onEndEdit.AddListener(ReceiveStringInput);
    }

    private void ReceiveStringInput(string playerInput)
    {
        charSheet.characterName = playerInput;
    }
}
