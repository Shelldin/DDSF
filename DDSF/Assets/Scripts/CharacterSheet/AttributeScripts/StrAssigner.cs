
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

        if (charSheet.str <10)
        {
            if (charSheet.str % 2 == 0)//from unity forums https://answers.unity.com/questions/1036351/how-to-tell-if-an-int-is-even.html
            {
                modifierFloat = Mathf.Floor((charSheet.str - 10)/2 - 1) + 1f;
            }
            else
            {
                modifierFloat = Mathf.Floor((charSheet.str - 10)/2 - 1);
            }
        }

        else
        {
            modifierFloat = Mathf.Floor((charSheet.str - 10)/2); 
        }

        modifierText.text = modifierFloat.ToString();
    }
}
