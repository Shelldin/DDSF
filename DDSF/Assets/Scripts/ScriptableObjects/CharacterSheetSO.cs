using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterSheetSO : ScriptableObject
{
    public string characterName;

    public int level,
        experience,
        proficiencyBonus,
        str,
        dex,
        con,
        intel,
        wis,
        cha,
        hitPointMax,
        currentHitPoints,
        tempHitPoints,
        armorClass,
        walkSpeed,
        walkSpeedSpace,
        swimSpeed,
        swimSpeedSpace,
        flySpeed,
        flySpeedSpace;
    
    public Dropdown characterClass,
        characterSubClass,
        characterRace,
        characterSubRace;
}
