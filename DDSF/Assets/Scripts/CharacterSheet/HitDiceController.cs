using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitDiceController : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public Text currentHitDice;
    public Text maxHitDice;
    public Text maxHitDiceHeader;
    public Text maxHitDiceSideNumberHeader;
    public InputField hitDiceInputField;
    public InputField expInputField;
    public Dropdown classDropdownMenu;

    private void Start()
    {
        classDropdownMenu.onValueChanged.AddListener(SetMaxHitDiceSideNumber);
        expInputField.onEndEdit.AddListener(SetMaxDiceNumber);
        hitDiceInputField.onEndEdit.AddListener(SetCurrentDiceNumber);
    }

    private void SetMaxHitDiceSideNumber(int classSelectValue)
    {
        if (classSelectValue == 0)
        {
            charSheet.hitDiceSideInt = 0;
        }

        if (classSelectValue == 11 || classSelectValue == 13)
        {
            charSheet.hitDiceSideInt = 6;
        }

        if (classSelectValue == 1 || classSelectValue == 3 || classSelectValue == 4 || classSelectValue == 5 || classSelectValue == 7 ||
            classSelectValue == 10 || classSelectValue == 12)
        {
            charSheet.hitDiceSideInt = 8;
        }

        if (classSelectValue == 6 || classSelectValue == 8 || classSelectValue == 9)
        {
            charSheet.hitDiceSideInt = 10;
        }

        if (classSelectValue == 2)
        {
            charSheet.hitDiceSideInt = 12;
        }
        
        maxHitDiceSideNumberHeader.text = charSheet.hitDiceSideInt.ToString();
    }

    private void SetMaxDiceNumber(string expInput)
    {
        charSheet.maxHitDice = charSheet.level;
        maxHitDice.text = charSheet.level.ToString();
        maxHitDiceHeader.text = charSheet.maxHitDice.ToString();
        if (charSheet.currentHitDice > charSheet.maxHitDice)
        {
            charSheet.currentHitDice = charSheet.maxHitDice;
            currentHitDice.text = charSheet.currentHitDice.ToString();
        }
    }

    private void SetCurrentDiceNumber(string playerInput)
    {
        charSheet.currentHitDice = charSheet.currentHitDice + int.Parse(playerInput);
        if (charSheet.currentHitDice <0)
        {
            charSheet.currentHitDice = 0;
        }

        if (charSheet.currentHitDice > charSheet.maxHitDice)
        {
            charSheet.currentHitDice = charSheet.maxHitDice;
        }
        currentHitDice.text = charSheet.currentHitDice.ToString();
        hitDiceInputField.text = null;
    }
    
}
