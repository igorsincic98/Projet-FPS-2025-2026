using UnityEngine;

public class PuzzleButton3Controller : MonoBehaviour
{   
    [SerializeField] private PuzzleDoorController _puzzleDoor3;
    [SerializeField] private PuzzleDoorController _puzzleDoor2;

    [SerializeField] private bool _doorProcessing;
    [SerializeField] private float _doorCooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _doorProcessing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_doorProcessing)
        {
            _doorCooldown -= Time.deltaTime;
        }

        if (_doorCooldown <= 0f)
        {
            _doorProcessing = false;
        }
    }

    public void Interact()
    {
        if (_doorProcessing == false)
        {
            _puzzleDoor3.ChangeState();
            _puzzleDoor2.ChangeState();
            _doorProcessing = true;
            _doorCooldown = 1f;
        }
    }
}
