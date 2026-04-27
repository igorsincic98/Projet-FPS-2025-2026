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
        _keyKeypad.Interact();
        _keypad.Interact();
        _exitButton.Interact();
    }
}
