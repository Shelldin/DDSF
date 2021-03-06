﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCharacterSheetData : MonoBehaviour
{
    /* CharacterClassIndex Key:   RaceIndex Key:            Background Key:
     * 0 = Select Class...        0 = Select Race           0 = Select Background
     * 1 = Artificer              1 = Aarakocra             1 = Acolyte
     *                            2 = Aasimar               2 = Anthropologist
     * 2 = Barbarian              3 = Bugbear               3 = Archaeologist
     * 3 = Bard                   4 = Changeling            4 = Charlatan
     * 4 = Cleric                 5 = Dragonborn            5 = City Watch
     * 5 = Druid                  6 = Dwarf                 6 = Clan Crafter
     * 6 = Fighter                7 = Elf                   7 = Cloistered Scholar
     * 7 = Monk                   8 = Firbolg               8 = Courtier
     * 8 = Paladin                9 = Genasi                9 = Criminal
     * 9 = Ranger                 10 = Gith                 10 = Entertainer
     * 10 = Rogue                 11 = Gnome                11 = Faction Agent
     * 11 = Sorcerer              12 = Goblin               12 = Far Traveler
     * 12 = Warlock               13 = Goliath              13 = Fisher
     * 13 = Wizard                14 = Half-Elf             14 = Folk Hero
     *                            15 = Half-Orc             15 = Gladiator
     *                            16 = Halfling             16 = Guild Artisan
     *                            17 = Hobgoblin            17 = Guild Merchant
     *                            18 = Human                18 = Haunted One
     *                            19 = Kalashtar            19 = Hermit
     *                            20 = Kenku                20 = House Agent
     *                            21 = Kobold               21 = Inheritor
     *                            22 = Lizardfolk           22 = Investigator
     *                            23 = Orc                  23 = Knight of the Order
     *                            24 = Shifter              24 = Marine
     *                            25 = Tabaxi               25 = Mercenary Veteran
     *                            26 = Tiefling             26 = Noble
     *                            27 = Tortle               27 = Noble Knight
     *                            28 = Triton               28 = Outlander
     *                            29 = Warforged            29 = Pirate
     *                            30 = Yaun-ti Pureblood    30 = Sage
     *                                                      31 = Sailor
     *                                                      32 = Shipwright
     *                                                      33 = Smuggler
     *                                                      34 = Soldier
     *                                                      35 = Spy
     *                                                      36 = Tribe Member
     *                                                      37 = Urban Bounty Hunter
     *                                                      38 = Urchin
     *                                                      39 = Waterdhavian Noble
     */
    
    public CharacterSheetSO charSheet;
    public InputField charNameInputField,
        armorClassInputField,
        initiativeInputField,
        speedInputField,
        flySpeedInputField,
        swimSpeedInputField;
    
    
    
    public List<Dropdown> dropdownMainMenus = new List<Dropdown>();
    
    public List<GameObject> subMenus = new List<GameObject>();
    public List<Dropdown> dropdownSubClassMenus = new List<Dropdown>();
    
    public List<GameObject> subRaceMenuGameObjects = new List<GameObject>();
    public List<Dropdown> dropdownSubRaceMenus = new List<Dropdown>();
    
    public List<Text> textField = new List<Text>();
    public List<Toggle> deathSaveToggles = new List<Toggle>();
    
    public List<InputField> attributeInputFields = new List<InputField>();
    public List<Text> attributeModifierTexts = new List<Text>();
    

    private float strModifier,
        dexModifier,
        conModifier,
        intelModifier,
        wisModifier,
        chaModifier;

    public InputField inspirationInputField;
    public Text proficiencyBonusText;
    
    public List<Toggle> savingThrowToggles = new List<Toggle>();
    

    //private int[] subAtThree = {1, 2, 3, 6, 7, 8, 9, 10};

    private void Awake()
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
        
        LoadHitPointValues();
        LoadHitDiceText();
        
        LoadDeathSaves();
        
        LoadArmorClass();
        LoadInitiative();
        LoadSpeeds();
        
        LoadAttributes();
        
        LoadInspiration();
        LoadProficiencyBonus();
        
        LoadSavingThrows();
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

    private void LoadHitPointValues()
    {
        textField[2].text = charSheet.currentHitPoints.ToString();
        textField[3].text = charSheet.hitPointMax.ToString();
        textField[4].text = charSheet.tempHitPoints.ToString();
    }

    private void LoadHitDiceText()
    {
        textField[5].text = charSheet.currentHitDice.ToString();
        textField[6].text = charSheet.maxHitDice.ToString();
        textField[7].text = charSheet.maxHitDice.ToString();
        textField[8].text = charSheet.hitDiceSideInt.ToString();
    }

    private void LoadDeathSaves()
    {
        for (int i = 0; i < deathSaveToggles.Count; i++)
        {
            deathSaveToggles[i].isOn = charSheet.deathSaveBools[i];
        }
    }

    private void LoadArmorClass()
    {
        armorClassInputField.text = charSheet.armorClass.ToString();
    }
    
    private void LoadInitiative()
    {
        initiativeInputField.text = charSheet.initiative.ToString();
    }
    
    private void LoadSpeeds()
    {
        speedInputField.text = charSheet.walkSpeed.ToString();
        flySpeedInputField.text = charSheet.flySpeed.ToString();
        swimSpeedInputField.text = charSheet.swimSpeed.ToString();
    }

    private void LoadAttributes()
    {
        attributeInputFields[0].text = charSheet.str.ToString();
        attributeInputFields[1].text = charSheet.dex.ToString();
        attributeInputFields[2].text = charSheet.con.ToString();
        attributeInputFields[3].text = charSheet.intel.ToString();
        attributeInputFields[4].text = charSheet.wis.ToString();
        attributeInputFields[5].text = charSheet.cha.ToString();
        
        if (charSheet.str <10)
        {
            if (charSheet.str % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                strModifier = Mathf.Floor((charSheet.str - 10)/2 - 1) + 1f;
            }
            else
            {
                strModifier = Mathf.Floor((charSheet.str - 10)/2 - 1);
            }
        }

        else
        {
            strModifier = Mathf.Floor((charSheet.str - 10)/2); 
        }

        attributeModifierTexts[0].text = strModifier.ToString();
        
        if (charSheet.dex <10)
        {
            if (charSheet.dex % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                dexModifier = Mathf.Floor((charSheet.dex - 10)/2 - 1) + 1f;
            }
            else
            {
                dexModifier = Mathf.Floor((charSheet.dex - 10)/2 - 1);
            }
        }

        else
        {
            dexModifier = Mathf.Floor((charSheet.dex - 10)/2); 
        }

        attributeModifierTexts[1].text = dexModifier.ToString();
        
        if (charSheet.con <10)
        {
            if (charSheet.con % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                conModifier = Mathf.Floor((charSheet.con - 10)/2 - 1) + 1f;
            }
            else
            {
                conModifier = Mathf.Floor((charSheet.con - 10)/2 - 1);
            }
        }

        else
        {
            conModifier = Mathf.Floor((charSheet.con - 10)/2); 
        }

        attributeModifierTexts[2].text = conModifier.ToString();
        
        if (charSheet.intel <10)
        {
            if (charSheet.intel % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                intelModifier = Mathf.Floor((charSheet.intel - 10)/2 - 1) + 1f;
            }
            else
            {
                intelModifier = Mathf.Floor((charSheet.intel - 10)/2 - 1);
            }
        }

        else
        {
            intelModifier = Mathf.Floor((charSheet.intel - 10)/2); 
        }

        attributeModifierTexts[3].text = intelModifier.ToString();
        
        if (charSheet.wis <10)
        {
            if (charSheet.wis % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                wisModifier = Mathf.Floor((charSheet.wis - 10)/2 - 1) + 1f;
            }
            else
            {
                wisModifier = Mathf.Floor((charSheet.wis - 10)/2 - 1);
            }
        }

        else
        {
            wisModifier = Mathf.Floor((charSheet.wis - 10)/2); 
        }

        attributeModifierTexts[4].text = wisModifier.ToString();
        
        if (charSheet.cha <10)
        {
            if (charSheet.cha % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                chaModifier = Mathf.Floor((charSheet.cha - 10)/2 - 1) + 1f;
            }
            else
            {
                chaModifier = Mathf.Floor((charSheet.cha - 10)/2 - 1);
            }
        }

        else
        {
            chaModifier = Mathf.Floor((charSheet.cha - 10)/2); 
        }

        attributeModifierTexts[5].text = chaModifier.ToString();
        
    }

    private void LoadInspiration()
    {
        inspirationInputField.text = charSheet.inspiration.ToString();
    }

    private void LoadProficiencyBonus()
    {
        proficiencyBonusText.text = charSheet.proficiencyBonus.ToString();
    }

    private void LoadSavingThrows()
    {
        for (int i = 0; i < savingThrowToggles.Count; i++)
        {
            savingThrowToggles[i].isOn = charSheet.savingThrowBools[i];
        }
    }
}
