using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DiceRoller : MonoBehaviour
{

    public DiceIntSO diceInfo;

    public int[] rollInt;

    public Text resultText;
    
    private int rollIntSum,
        modifier,
        totalResult;

    private string resultMessage;
    
    public List<string> resultMessageLog = new List<string>();

    private void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            rollInt = new int[diceInfo.diceInt];
            
            for (int i = 0; i < rollInt.Length; i++)
            {
                rollInt[i] = Random.Range(1, diceInfo.sideInt+1);
               
            }

            rollIntSum = rollInt.Sum();
            modifier = diceInfo.modifierInt;
           totalResult = rollIntSum + modifier;
           resultMessage = rollIntSum.ToString() + " (" + diceInfo.diceInt.ToString() + "d" + diceInfo.sideInt.ToString()
                           + ")" + " + " + modifier.ToString() + " = " + totalResult.ToString();
           LogRollResults();
           string displayTextString = string.Join("\n", resultMessageLog.ToArray());
           resultText.text = displayTextString;
        }
    }

    private void LogRollResults()
    {
        resultMessageLog.Add(resultMessage + "\n");
    }
        
}
