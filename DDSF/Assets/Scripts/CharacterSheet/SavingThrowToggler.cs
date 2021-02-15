
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class SavingThrowToggler : MonoBehaviour
{
    public Toggle savingThrowToggle;
    public UnityEvent toggleEvent;

    private void Start()
    {
        savingThrowToggle.onValueChanged.AddListener(ToggleSavingThrow);
    }

    private void ToggleSavingThrow(bool isOnBool)
    {
        toggleEvent.Invoke();
    }
}
