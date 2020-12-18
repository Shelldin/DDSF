using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPointValueAssigner : MonoBehaviour
{
    public List<InputField> hitPointInputFields = new List<InputField>();
    public List<Text> hitPointText = new List<Text>();
    public CharacterSheetSO charSheet;

    private void Start()
    {
        hitPointInputFields[0].onEndEdit.AddListener(AssignCurrentHpValue);
        hitPointInputFields[1].onEndEdit.AddListener(AssignMaxHpValue);
        hitPointInputFields[2].onEndEdit.AddListener(AssignTempHpValue);
    }

    private void AssignCurrentHpValue(string playerInput)
    {
        charSheet.currentHitPoints = charSheet.currentHitPoints + int.Parse(playerInput);
        if (charSheet.currentHitPoints < 0)
        {
            charSheet.currentHitPoints = 0;
        }

        if (charSheet.currentHitPoints > charSheet.hitPointMax)
        {
            charSheet.currentHitPoints = charSheet.hitPointMax;
        }
        hitPointText[0].text = charSheet.currentHitPoints.ToString();
        hitPointInputFields[0].text = null;
    }

    private void AssignMaxHpValue(string playerInput)
    {
        charSheet.hitPointMax = charSheet.hitPointMax + int.Parse(playerInput);
        if (charSheet.hitPointMax < 1)
        {
            charSheet.hitPointMax = 1;
        }

        hitPointText[1].text = charSheet.hitPointMax.ToString();
        hitPointInputFields[1].text = null;
    }

    private void AssignTempHpValue(string playerInput)
    {
        charSheet.tempHitPoints = charSheet.tempHitPoints + int.Parse(playerInput);
        if (charSheet.tempHitPoints < 0)
        {
            charSheet.tempHitPoints = 0;
        }

        hitPointText[2].text = charSheet.tempHitPoints.ToString();
        hitPointInputFields[2].text = null;
    }
    
    
}
