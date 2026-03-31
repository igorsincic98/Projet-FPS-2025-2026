using UnityEngine;

public class Interactable : MonoBehaviour
{
    public KeypadController keypad;
    public string promptMessage;

    public void Interacting()
    {
        keypad.Interact();
    }
}
