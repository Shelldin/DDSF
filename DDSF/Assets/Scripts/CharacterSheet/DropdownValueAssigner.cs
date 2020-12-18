using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownValueAssigner : MonoBehaviour
{
    public List<Dropdown> dropdownMainMenus = new List<Dropdown>();
    
    public List<GameObject> subMenuGameObjects = new List<GameObject>();
    public List<Dropdown> dropdownSubClassMenus = new List<Dropdown>();
    
    public List<GameObject> subRaceMenuGameObjects = new List<GameObject>();
    public List<Dropdown>  dropdownSubRaceMenus = new List<Dropdown>();
    
    public CharacterSheetSO charSheet;

    private void Start()
    {
        dropdownMainMenus[0].onValueChanged.AddListener(AssignClassMenuDropdownValue);
        for (int i = 0; i < dropdownSubClassMenus.Count; i++)
        {
            dropdownSubClassMenus[i].onValueChanged.AddListener(AssignSubClassMenuDropdownValue);
        }
        
        dropdownMainMenus[1].onValueChanged.AddListener(AssignRaceDropdownMenuValue);
        for (int i = 0; i < dropdownSubRaceMenus.Count; i++)
        {
            dropdownSubRaceMenus[i].onValueChanged.AddListener(AssignDropdownSubRaceMenuValue);
        }
        
        dropdownMainMenus[2].onValueChanged.AddListener(AssignBackgroundDropdownValue);
        
        dropdownMainMenus[3].onValueChanged.AddListener(AssignAlignmentDropdownValue);
        
    }

    private void AssignClassMenuDropdownValue(int classChoiceValue)
    {
        charSheet.classMenuDropdownValue = classChoiceValue;
        SetAllSubMenuGameObjectsInactive();
        SetSubMenuGameObjectsActive();
        SetSubMenuIsInteractable();
    }

    private void AssignSubClassMenuDropdownValue(int subClassChoiceValue)
    {
        charSheet.subClassMenuDropdownValue = subClassChoiceValue;
    }
    
    private void SetAllSubMenuGameObjectsInactive()
    {
        for (int i = 0; i < subMenuGameObjects.Count; i++)
        {
            subMenuGameObjects[i].SetActive(false);
        }
    }
    
    private void SetSubMenuGameObjectsActive()
    {
        subMenuGameObjects[dropdownMainMenus[0].value].SetActive(true);
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

    private void AssignRaceDropdownMenuValue(int raceChoiceValue)
    {
        charSheet.raceMenuDropdownValue = raceChoiceValue;
        SetAllSubRaceMenuGameObjectsInactive();
        SetSubRaceMenuGameObjectActive();
    }

    private void SetAllSubRaceMenuGameObjectsInactive()
    {
        for (int i = 0; i < subRaceMenuGameObjects.Count; i++)
        {
            subRaceMenuGameObjects[i].SetActive(false);
        }
    }

    private void SetSubRaceMenuGameObjectActive()
    {
        subRaceMenuGameObjects[dropdownMainMenus[1].value].SetActive(true);
    }

    private void AssignDropdownSubRaceMenuValue(int subRaceChoiceValue)
    {
        charSheet.subRaceMenuDropdownValue = subRaceChoiceValue;
    }

    private void AssignBackgroundDropdownValue(int bGChoiceValue)
    {
        charSheet.backgroundDropdownValue = bGChoiceValue;
    }

    private void AssignAlignmentDropdownValue(int alignmentChoiceValue)
    {
        charSheet.alignmentDropdownValue = alignmentChoiceValue;
    }
}
