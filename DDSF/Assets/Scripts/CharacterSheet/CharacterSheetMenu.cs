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


    private void Start()
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
    }
}
