using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WisAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public Text modifierText;

    private int modifierInt;
    private float modifierFloat;
    

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignWis);
    }

    private void AssignWis(string playerInput)
    {
        charSheet.wis = int.Parse(playerInput);
        if (charSheet.wis <1)
        {
            charSheet.wis = 1;
            inputField.text = charSheet.wis.ToString();
        }

        if (charSheet.wis <10)
        {
            if (charSheet.wis % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                modifierFloat = Mathf.Floor((charSheet.wis - 10)/2 - 1) + 1f;
            }
            else
            {
                modifierFloat = Mathf.Floor((charSheet.wis - 10)/2 - 1);
            }
        }

        else
        {
            modifierFloat = Mathf.Floor((charSheet.wis - 10)/2); 
        }

        modifierText.text = modifierFloat.ToString();
    }
}
