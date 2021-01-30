
using UnityEngine;
using UnityEngine.UI;

public class SpeedAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignSpeed);
    }

    private void AssignSpeed(string playerInput)
    {
        charSheet.walkSpeed = int.Parse(playerInput);
        if (charSheet.walkSpeed <0)
        {
            charSheet.walkSpeed = 0;
            inputField.text = charSheet.walkSpeed.ToString();
        }
    }
}
