using UnityEngine;

public class Interactable : MonoBehaviour
{
    public KeypadController _keypad;
    public KeyKeypadController _keyKeypad;
    public TestButtonExit _exitButton;
    public string _promptMessage;

    public void Interacting()
    {
        Debug.Log("Interacting");
        if (_keypad != null)
        {
            _keypad.Interact();
        }
        if (_keyKeypad != null)
        {
            _keyKeypad.Interact();
        }
        if (_exitButton != null)
        {
            _exitButton.Interact();
        }
    }
}
