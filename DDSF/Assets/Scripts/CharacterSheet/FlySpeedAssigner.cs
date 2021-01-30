
using UnityEngine;
using UnityEngine.UI;

public class FlySpeedAssigner : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;

    void Start()
    {
        inputField.onEndEdit.AddListener(AssignFlySpeed);
    }

    private void AssignFlySpeed(string playerInput)
    {
        charSheet.flySpeed = int.Parse(playerInput);
        if (charSheet.flySpeed <0)
        {
            charSheet.flySpeed = 0;
            inputField.text = charSheet.flySpeed.ToString();
        }
    }
}
