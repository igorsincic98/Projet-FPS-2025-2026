using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator doorOpen;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckOpenDoor()
    {
        Debug.Log(transform.childCount);
        if (transform.childCount <= 1)
        {
            doorOpen.Play("DoorOpenTop", 0, 0f);
        }
    }
    
}
