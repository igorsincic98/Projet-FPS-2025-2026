using UnityEngine;

public class Interactable : MonoBehaviour
{
    public KeypadController keypad;
    public string promptMessage;

    public void Interacting()
    {
        Debug.Log("Interacting");
        keypad.Interact();
    }
}
