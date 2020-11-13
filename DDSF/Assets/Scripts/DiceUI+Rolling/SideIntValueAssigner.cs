using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideIntValueAssigner : MonoBehaviour
{
    public DiceIntSO diceInfo;
    public InputField inputField;
    [Range(1,100)]
    public int sideIntRange;

    private void Awake()
    {
        //from unity text adventure tutorial
        inputField.onEndEdit.AddListener(ReceiveStringValueInput);
    }

    private void ReceiveStringValueInput(string playerInput)
    {
        int.TryParse(playerInput, out sideIntRange);
        if (sideIntRange > 100)
        {
            sideIntRange = 100;
        }

        if (sideIntRange < 1)
        {
            sideIntRange = 1;
        }

        diceInfo.sideInt = sideIntRange;
    }
}
