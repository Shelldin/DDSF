
using UnityEngine;
using UnityEngine.UI;

public class InitiativeAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignInitiative);
    }

    private void AssignInitiative(string playerInput)
    {
        charSheet.initiative = int.Parse(playerInput);
        if (charSheet.initiative <0)
        {
            charSheet.initiative = 0;
            inputField.text = charSheet.initiative.ToString();
        }
    }
}
