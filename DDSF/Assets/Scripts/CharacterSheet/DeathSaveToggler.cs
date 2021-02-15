
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DeathSaveToggler : MonoBehaviour
{
    public Toggle deathSaveToggle;
    public UnityEvent toggleEvent;

    private void Start()
    {
        deathSaveToggle.onValueChanged.AddListener(ToggleDeathSave);
    }

    private void ToggleDeathSave(bool isOnBool)
    {
        toggleEvent.Invoke();
    }

}
