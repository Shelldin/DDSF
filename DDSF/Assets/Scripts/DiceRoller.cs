using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    public DiceIntSO diceInfo;
    private int rollResult,
        modifier,
        totalResult;

    private string resultMessage;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rollResult = Random.Range(1, diceInfo.sideInt+1);
            modifier = diceInfo.modifierInt;
            totalResult = rollResult + modifier;
            resultMessage = rollResult.ToString() + " + " + modifier.ToString() + " = " + totalResult.ToString();
            Debug.Log(resultMessage);
        }  
    }

    public void Roll()
    {
       
    }
        
}
