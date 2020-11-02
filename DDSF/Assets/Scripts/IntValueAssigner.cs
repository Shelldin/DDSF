using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntValueAssigner : MonoBehaviour
{
   public DiceIntSO diceInfo;
   public InputField inputField;
   [Range(1,100)]
   public int diceIntRange,
      sideIntRange,
      modifierIntRange;

   private void Awake()
   {
      inputField.onEndEdit.AddListener(ReceiveStringValueInput);
   }

   private void ReceiveStringValueInput(string playerInput)
   {
      int.TryParse(playerInput, out diceIntRange);
      Debug.Log(diceIntRange);
   }
}
