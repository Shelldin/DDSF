
using System;
using UnityEngine;
using UnityEngine.UI;

public class StrAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public Text modifierText;

    private int modifierInt;
    private float modifierFloat;

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignStr);
    }

    private void AssignStr(string playerInput)
    {
        charSheet.str = int.Parse(playerInput);
        if (charSheet.str <1)
        {
            charSheet.str = 1;
            inputField.text = charSheet.str.ToString();
        }

        modifierFloat = Mathf.Floor((charSheet.str - 10) / 2);
        Debug.Log(modifierFloat.ToString());
    }
}
