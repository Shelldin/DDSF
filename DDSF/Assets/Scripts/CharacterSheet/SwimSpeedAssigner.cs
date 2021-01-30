
using UnityEngine;
using UnityEngine.UI;

public class SwimSpeedAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignSwimSpeed);
    }

    private void AssignSwimSpeed(string playerInput)
    {
        charSheet.swimSpeed = int.Parse(playerInput);
        if (charSheet.swimSpeed <0)
        {
            charSheet.swimSpeed = 0;
            inputField.text = charSheet.swimSpeed.ToString();
        }
    }
}
