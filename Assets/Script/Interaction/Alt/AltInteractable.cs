using UnityEngine;

public abstract class AltInteractable : MonoBehaviour
{
    public string promptMessage;

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        
    }
    
}
