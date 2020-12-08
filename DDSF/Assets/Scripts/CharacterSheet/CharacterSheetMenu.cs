using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CharacterSheetMenu : MonoBehaviour
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
    
    public UnityEvent ClassMenuEvent,
        artificerMenuEvent,
        barbarianMenuEvent,
        bardMenuEvent,
        clericMenuEvent,
        druidMenuEvent,
        fighterMenuEvent,
        monkMenuEvent,
        paladinMenuEvent,
        rangerMenuEvent,
        rogueMenuEvent,
        sorcererMenuEvent,
        warlockMenuEvent,
        wizardMenuEventEvent;

    public CharacterSheetSO charSheet;
    public Text characterNameField;


    private void Awake()
    {
        
    }

    private void Update()
    {
       
    }

    public void SelectCharacterClass(int characterClassIndex)
    {
        if (characterClassIndex == 0)
        {
            ClassMenuEvent.Invoke();
        }

        if (characterClassIndex == 1)
        {
            artificerMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 2)
        {
            barbarianMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 3)
        {
            bardMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 4)
        {
            clericMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 5)
        {
            druidMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 6)
        {
            fighterMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 7)
        {
            monkMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 8)
        {
            paladinMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 9)
        {
            rangerMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 10)
        {
            rogueMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 11)
        {
            sorcererMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 12)
        {
            warlockMenuEvent.Invoke();
        }
        
        if (characterClassIndex == 13)
        {
            wizardMenuEventEvent.Invoke();
        }
    }
}
