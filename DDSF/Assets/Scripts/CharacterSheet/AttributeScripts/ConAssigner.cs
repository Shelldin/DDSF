using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public Text modifierText;

    private int modifierInt;
    private float modifierFloat;
    

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignCon);
    }

    private void AssignCon(string playerInput)
    {
        charSheet.con = int.Parse(playerInput);
        if (charSheet.con <1)
        {
            charSheet.con = 1;
            inputField.text = charSheet.con.ToString();
        }

        if (charSheet.con <10)
        {
            if (charSheet.con % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                modifierFloat = Mathf.Floor((charSheet.con - 10)/2 - 1) + 1f;
            }
            else
            {
                modifierFloat = Mathf.Floor((charSheet.con - 10)/2 - 1);
            }
        }

        else
        {
            modifierFloat = Mathf.Floor((charSheet.con - 10)/2); 
        }

        modifierText.text = modifierFloat.ToString();
    }
}
