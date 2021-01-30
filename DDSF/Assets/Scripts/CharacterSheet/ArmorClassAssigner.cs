
using UnityEngine;
using UnityEngine.UI;

public class ArmorClassAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignArmorClass);
    }

    private void AssignArmorClass(string playerInput)
    {
        charSheet.armorClass = int.Parse(playerInput);
        if (charSheet.armorClass <0)
        {
            charSheet.armorClass = 0;
            inputField.text = charSheet.armorClass.ToString();
        }
    }
        
        
}
