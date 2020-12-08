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

    //private int[] subAtThree = {1, 2, 3, 6, 7, 8, 9, 10};

    private void Awake()
    {
        charNameInputField.text = charSheet.characterName;
        for (int i = 0; i < subMenus.Count; i++)
        {
            subMenus[i].SetActive(false);
        }
        dropdownMainMenus[0].value = charSheet.classMenuDropdownValue;
        subMenus[dropdownMainMenus[0].value].SetActive(true);
        charSheet.subClassMenuDropdownValue = dropdownMainMenus[0].value;
        if ((charSheet.subClassMenuDropdownValue == 1 && charSheet.level<3) || (charSheet.subClassMenuDropdownValue == 2 && charSheet.level<3) || 
            (charSheet.subClassMenuDropdownValue == 3 && charSheet.level<3) || (charSheet.subClassMenuDropdownValue == 6 && charSheet.level<3) ||
            (charSheet.subClassMenuDropdownValue == 7 && charSheet.level<3) || (charSheet.subClassMenuDropdownValue == 8 && charSheet.level<3) ||
            (charSheet.subClassMenuDropdownValue == 9 && charSheet.level<3) || (charSheet.subClassMenuDropdownValue == 10 && charSheet.level<3) ||
            (charSheet.subClassMenuDropdownValue == 5 && charSheet.level<2) || (charSheet.subClassMenuDropdownValue == 13 && charSheet.level<2))
        {
            dropdownSubClassMenus[charSheet.subClassMenuDropdownValue].interactable = false;
        }
        else
        {
            dropdownSubClassMenus[charSheet.subClassMenuDropdownValue].interactable = true;
        }
        
        
    }
}
