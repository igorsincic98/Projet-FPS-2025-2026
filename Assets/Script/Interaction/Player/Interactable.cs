using UnityEngine;

public class Interactable : MonoBehaviour
{
    public KeypadController _keypad;
    public KeyKeypadController _keyKeypad;
    public TestButtonExit _exitButton;
    public PuzzleButton1Controller _puzzleButton1;
    public PuzzleButton2Controller _puzzleButton2;
    public PuzzleButton3Controller _puzzleButton3;
    public PuzzleButton4Controller _puzzleButton4;

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

        if (_puzzleButton1 != null)
        {
            _puzzleButton1.Interact();
        }
        if (_puzzleButton2 != null)
        {
            _puzzleButton2.Interact();
        }
        if (_puzzleButton3 != null)
        {
            _puzzleButton3.Interact();
        }
        if (_puzzleButton4 != null)
        {
            _puzzleButton4.Interact();
        }

    }
}
