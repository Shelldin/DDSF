using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
[CreateAssetMenu]
public class CharacterSheetSO : ScriptableObject
{
    public string characterName;
    public List<bool> deathSaveBools = new List<bool>();
    public List<bool> savingThrowBools = new List<bool>();

    public int classMenuDropdownValue,
        subClassMenuDropdownValue,
        raceMenuDropdownValue,
        subRaceMenuDropdownValue,
        backgroundDropdownValue,
        alignmentDropdownValue,
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
        currentHitDice,
        hitDiceSideInt,
        maxHitDice,
        armorClass,
        walkSpeed,
        walkSpeedSpace,
        swimSpeed,
        swimSpeedSpace,
        flySpeed,
        flySpeedSpace,
        initiative,
        inspiration;

    public void DeathSaveToggleSOne()
    {
        deathSaveBools[0] = !deathSaveBools[0];
    }
    
    public void DeathSaveToggleSTwo()
    {
        deathSaveBools[1] = !deathSaveBools[1];
    }
    public void DeathSaveToggleSThree()
    {
        deathSaveBools[2] = !deathSaveBools[2];
    }
    public void DeathSaveToggleFOne()
    {
        deathSaveBools[3] = !deathSaveBools[3];
    }
    public void DeathSaveToggleFTwo()
    {
        deathSaveBools[4] = !deathSaveBools[4];
    }
    public void DeathSaveToggleFThree()
    {
        deathSaveBools[5] = !deathSaveBools[5];
    }

    
    
}
