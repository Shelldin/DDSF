using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DexAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public Text modifierText;

    private int modifierInt;
    private float modifierFloat;
    

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignDex);
    }

    private void AssignDex(string playerInput)
    {
        charSheet.dex = int.Parse(playerInput);
        if (charSheet.dex <1)
        {
            charSheet.dex = 1;
            inputField.text = charSheet.dex.ToString();
        }

        if (charSheet.dex <10)
        {
            if (charSheet.dex % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                modifierFloat = Mathf.Floor((charSheet.dex - 10)/2 - 1) + 1f;
            }
            else
            {
                modifierFloat = Mathf.Floor((charSheet.dex - 10)/2 - 1);
            }
        }

        else
        {
            modifierFloat = Mathf.Floor((charSheet.dex - 10)/2); 
        }

        modifierText.text = modifierFloat.ToString();
    }
}
