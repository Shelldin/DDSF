
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencyAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public Text proficiencyText;
    public InputField expInputField;

    private void Start()
    {
        expInputField.onEndEdit.AddListener(CallCoroutine);
    }

    private IEnumerator AssignProficiencyBonus()
    {
        
        yield return new WaitForSeconds(1);
        
        if (charSheet.level<5)
        {
            charSheet.proficiencyBonus = 2;
        }

        if (charSheet.level > 4 && charSheet.level < 9)
        {
            charSheet.proficiencyBonus = 3;
        }

        if (charSheet.level > 8 && charSheet.level < 13)
        {
            charSheet.proficiencyBonus = 4;
        }

        if (charSheet.level > 12 && charSheet.level < 17)
        {
            charSheet.proficiencyBonus = 5;
        }

        if (charSheet.level > 16 && charSheet.level < 21)
        {
            charSheet.proficiencyBonus = 6;
        }
        
        

        proficiencyText.text = charSheet.proficiencyBonus.ToString(); 
    }

    private void CallCoroutine(string playerInput)
    {
        StartCoroutine(AssignProficiencyBonus());
    }
}
