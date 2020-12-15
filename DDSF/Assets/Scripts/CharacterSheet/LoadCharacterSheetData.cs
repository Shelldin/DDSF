using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCharacterSheetData : MonoBehaviour
{
    /* CharacterClassIndex Key:   RaceIndex Key:
     * 0 = Select Class...        0 = Select Race
     * 1 = Artificer              1 = Aarakocra
     *                            2 = Aasimar
     * 2 = Barbarian              3 = Bugbear
     * 3 = Bard                   4 = Changeling
     * 4 = Cleric                 5 = Dragonborn
     * 5 = Druid                  6 = Dwarf
     * 6 = Fighter                7 = Elf
     * 7 = Monk                   8 = Firbolg
     * 8 = Paladin                9 = Genasi
     * 9 = Ranger                 10 = Gith
     * 10 = Rogue                 11 = Gnome
     * 11 = Sorcerer              12 = Goblin
     * 12 = Warlock               13 = Goliath
     * 13 = Wizard                14 = Half-Elf
     *                            15 = Half-Orc
     *                            16 = Halfling
     *                            17 = Hobgoblin
     *                            18 = Human
     *                            19 = Kalashtar
     *                            20 = Kenku
     *                            21 = Kobold
     *                            22 = Lizardfolk
     *                            23 = Orc
     *                            24 = Shifter
     *                            25 = Tabaxi
     *                            26 = Tiefling
     *                            27 = Tortle
     *                            28 = Triton
     *                            29 = Warforged
     *                            30 = Yaun-ti Pureblood
     */
    
    public CharacterSheetSO charSheet;
    public InputField charNameInputField;
    
    public List<Dropdown> dropdownMainMenus = new List<Dropdown>();
    
    public List<GameObject> subMenus = new List<GameObject>();
    public List<Dropdown> dropdownSubClassMenus = new List<Dropdown>();
    
    public List<GameObject> subRaceMenuGameObjects = new List<GameObject>();
    public List<Dropdown> dropdownSubRaceMenus = new List<Dropdown>();
    
    public List<Text> textField = new List<Text>();

    //private int[] subAtThree = {1, 2, 3, 6, 7, 8, 9, 10};

    private void Start()
    {
        LoadCharacterName();
        LoadCharacterLevelAndExp();
        
        SetAllSubMenuGameObjectsInactive();
        LoadClassDropdownValue();
        SetSubMenuGameObjectsActive();
        SetSubMenuIsInteractable();
        LoadSubClassDropdownValue();
        
        SetAllSubRaceMenuGameObjectsInactive();
        LoadRaceDropdownValue();
        SetSubRaceMenuGameObjectActive();
        LoadDropdownSubRaceMenuValue();
        
        LoadBackgroundDropdownValue();
        
        LoadAlignmentDropdownValue();
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

    private void SetAllSubMenuGameObjectsInactive()
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

    private void SetAllSubRaceMenuGameObjectsInactive()
    {
        for (int i = 0; i < subRaceMenuGameObjects.Count; i++)
        {
            subRaceMenuGameObjects[i].SetActive(false);
        }
    }

    private void LoadRaceDropdownValue()
    {
        dropdownMainMenus[1].value = charSheet.raceMenuDropdownValue;
    }

    private void SetSubRaceMenuGameObjectActive()
    {
        subRaceMenuGameObjects[dropdownMainMenus[1].value].SetActive(true);
    }

    private void LoadDropdownSubRaceMenuValue()
    {
        dropdownSubRaceMenus[dropdownMainMenus[1].value].value = charSheet.subRaceMenuDropdownValue;
    }

    private void LoadBackgroundDropdownValue()
    {
        dropdownMainMenus[2].value = charSheet.backgroundDropdownValue;
    }

    private void LoadAlignmentDropdownValue()
    {
        dropdownMainMenus[3].value = charSheet.alignmentDropdownValue;
    }
}
