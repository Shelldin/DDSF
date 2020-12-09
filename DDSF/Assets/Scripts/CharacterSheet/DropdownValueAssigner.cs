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
    public CharacterSheetSO charSheet;

    private void Awake()
    {
        dropdownMainMenus[0].onValueChanged.AddListener(AssignClassMenuDropdownValue);
        for (int i = 0; i < dropdownSubClassMenus.Count; i++)
        {
            dropdownSubClassMenus[i].onValueChanged.AddListener(AssignSubClassMenuDropdownValue);
        }
    }

    private void AssignClassMenuDropdownValue(int classChoiceValue)
    {
        charSheet.classMenuDropdownValue = classChoiceValue;
        SetSubMenuGameObjectsInactive();
        SetSubMenuGameObjectsActive();
        SetSubMenuIsInteractable();
    }

    private void AssignSubClassMenuDropdownValue(int subClassChoiceValue)
    {
        charSheet.subClassMenuDropdownValue = subClassChoiceValue;
    }
    
    private void SetSubMenuGameObjectsInactive()
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
    
    
}
