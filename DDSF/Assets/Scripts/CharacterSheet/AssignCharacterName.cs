using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignCharacterName : MonoBehaviour
{
    public InputField characterNameField;
    //public Text charNameFieldText;
    public CharacterSheetSO charSheet;
    
    private void Awake()
    {
        characterNameField.onEndEdit.AddListener(ReceiveStringInput);
        characterNameField.text = charSheet.characterName;
    }

    private void ReceiveStringInput(string playerInput)
    {
        charSheet.characterName = playerInput;
    }
}
