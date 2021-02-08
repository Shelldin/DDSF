using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IntelAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public Text modifierText;

    private int modifierInt;
    private float modifierFloat;
    

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignIntel);
    }

    private void AssignIntel(string playerInput)
    {
        charSheet.intel = int.Parse(playerInput);
        if (charSheet.intel <1)
        {
            charSheet.intel = 1;
            inputField.text = charSheet.intel.ToString();
        }

        if (charSheet.intel <10)
        {
            if (charSheet.intel % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                modifierFloat = Mathf.Floor((charSheet.intel - 10)/2 - 1) + 1f;
            }
            else
            {
                modifierFloat = Mathf.Floor((charSheet.intel - 10)/2 - 1);
            }
        }

        else
        {
            modifierFloat = Mathf.Floor((charSheet.intel - 10)/2); 
        }

        modifierText.text = modifierFloat.ToString();
    }
}
