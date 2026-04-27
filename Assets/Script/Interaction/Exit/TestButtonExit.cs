using UnityEngine;

public class TestButtonExit : MonoBehaviour
{
    [SerializeField] private ExitManager _exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        Debug.Log("Interacted");
        _exit.ExitOpens();
    }
    
}
