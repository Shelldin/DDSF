using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCharacterSheetData : MonoBehaviour
{
    /* CharacterClassIndex Key:
     * 0 = Select Class...
     * 1 = Artificer
     * 2 = Barbarian
     * 3 = Bard
     * 4 = Cleric
     * 5 = Druid
     * 6 = Fighter
     * 7 = Monk
     * 8 = Paladin
     * 9 = Ranger
     * 10 = Rogue
     * 11 = Sorcerer
     * 12 = Warlock
     * 13 = Wizard
     */
    
    public CharacterSheetSO charSheet;
    public InputField charNameInputField;
    public List<Dropdown> dropdownMainMenus = new List<Dropdown>();
    public List<GameObject> subMenus = new List<GameObject>();
    public List<Dropdown> dropdownSubClassMenus = new List<Dropdown>();
    public List<Text> textField = new List<Text>();

    //private int[] subAtThree = {1, 2, 3, 6, 7, 8, 9, 10};

    private void Awake()
    {
        LoadCharacterName();
        LoadCharacterLevelAndExp();
        
        SetSubMenuGameObjectsInactive();
        LoadClassDropdownValue();
        SetSubMenuGameObjectsActive();
        SetSubMenuIsInteractable();
        LoadSubClassDropdownValue();
    }

    private void LoadCharacterName()
    {
        charNameInputField.text = charSheet.characterName;
    }

    private void LoadCharacterLevelAndExp()
    {
        textField[0].text = charSheet.level.ToString();
        textField[1].text = charSheet.experience.ToString();
    }

    private void SetSubMenuGameObjectsInactive()
    {
        for (int i = 0; i < subMenus.Count; i++)
        {
            subMenus[i].SetActive(false);
        }
    }

    private void LoadClassDropdownValue()
    {
        dropdownMainMenus[0].value = charSheet.classMenuDropdownValue;
    }

    private void SetSubMenuGameObjectsActive()
    {
        subMenus[dropdownMainMenus[0].value].SetActive(true);
    }

    private void SetSubMenuIsInteractable()
    {
        if ((dropdownMainMenus[0].value == 1 && charSheet.level<3) || (dropdownMainMenus[0].value == 2 && charSheet.level<3) || 
            (dropdownMainMenus[0].value == 3 && charSheet.level<3) || (dropdownMainMenus[0].value == 6 && charSheet.level<3) ||
            (dropdownMainMenus[0].value == 7 && charSheet.level<3) || (dropdownMainMenus[0].value == 8 && charSheet.level<3) ||
            (dropdownMainMenus[0].value == 9 && charSheet.level<3) || (dropdownMainMenus[0].value == 10 && charSheet.level<3) ||
            (dropdownMainMenus[0].value == 5 && charSheet.level<2) || (dropdownMainMenus[0].value == 13 && charSheet.level<2))
        {
            dropdownSubClassMenus[dropdownMainMenus[0].value].interactable = false;
        }
        else
        {
            dropdownSubClassMenus[dropdownMainMenus[0].value].interactable = true;
        }
    }

    private void LoadSubClassDropdownValue()
    {
        dropdownSubClassMenus[dropdownMainMenus[0].value].value = charSheet.subClassMenuDropdownValue;
    }
    
    
}
