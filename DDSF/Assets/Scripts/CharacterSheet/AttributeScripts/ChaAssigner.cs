using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChaAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public Text modifierText;

    private int modifierInt;
    private float modifierFloat;
    

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignCha);
    }

    private void AssignCha(string playerInput)
    {
        charSheet.cha = int.Parse(playerInput);
        if (charSheet.cha <1)
        {
            charSheet.cha = 1;
            inputField.text = charSheet.cha.ToString();
        }

        if (charSheet.cha <10)
        {
            if (charSheet.cha % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                modifierFloat = Mathf.Floor((charSheet.cha - 10)/2 - 1) + 1f;
            }
            else
            {
                modifierFloat = Mathf.Floor((charSheet.cha - 10)/2 - 1);
            }
        }

        else
        {
            modifierFloat = Mathf.Floor((charSheet.cha - 10)/2); 
        }

        modifierText.text = modifierFloat.ToString();
    }
}
