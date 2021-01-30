
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InputTextAssinger : MonoBehaviour
{
    public CharacterSheetSO charSheet;
    public InputField inputField;
    public UnityEvent unityEvent;
    
        void Start()
    {
        inputField.onEndEdit.AddListener(OnEndInvoke);
    }

        private void OnEndInvoke(string playerInput)
        {
            unityEvent.Invoke();
        }
        
        
}
