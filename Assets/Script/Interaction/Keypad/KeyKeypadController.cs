using UnityEngine;

public class KeyKeypadController : MonoBehaviour
{
    [SerializeField] private bool _interactable;

    [SerializeField] private ExitManager _exit;
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
            _interactable = false;
            _exit.KeyPressed();

        }
    }
}
