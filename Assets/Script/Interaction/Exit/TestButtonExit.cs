using UnityEngine;

public class TestButtonExit : MonoBehaviour
{
    [SerializeField] private ExitManager _exit;

    [SerializeField] private bool _interactable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (_interactable)
        {
            Debug.Log("Interacted");
            _exit.ExitOpens();
            _interactable = false;
        }
    }
    
}
