using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModifierIntValueAssigner : MonoBehaviour
{
    public DiceIntSO diceInfo;
    public InputField inputField;
    [Range(-100, 100)] public int modifierIntRange;

    private void Awake()
    {
        //from unity text adventure tutorial
        inputField.onEndEdit.AddListener(ReceiveStringValueInput);
    }

    private void ReceiveStringValueInput(string playerInput)
    {
        int.TryParse(playerInput, out modifierIntRange);
        if (modifierIntRange > 100)
        {
            modifierIntRange = 100;
        }

        if (modifierIntRange < -100)
        {
            modifierIntRange = -100;
        }

        diceInfo.modifierInt = modifierIntRange;
    }
}
