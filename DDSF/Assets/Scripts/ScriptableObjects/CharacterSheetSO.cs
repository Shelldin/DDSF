using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
[CreateAssetMenu]
public class CharacterSheetSO : ScriptableObject
{
    public string characterName;

    public int classMenuDropdownValue,
        subClassMenuDropdownValue,
        raceMenuDropdownValue,
        subRaceMenuDropdownValue,
        level,
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
    
    
}
