using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceIntValueAssigner : MonoBehaviour
{
   public DiceIntSO diceInfo;
   public InputField inputField;
   [Range(1, 100)] public int diceIntRange;

   private void Awake()
   {
      //from unity text adventure tutorial
      inputField.onEndEdit.AddListener(ReceiveStringValueInput);
   }

   private void ReceiveStringValueInput(string playerInput)
   {
      int.TryParse(playerInput, out diceIntRange);
      if (diceIntRange > 100)
      {
         diceIntRange = 100;
      }

      if (diceIntRange < 1)
      {
         diceIntRange = 1;
      }

      diceInfo.diceInt = diceIntRange;
   }
}
