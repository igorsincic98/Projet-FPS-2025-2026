using UnityEngine;

public class PuzzleButton2Controller : MonoBehaviour
{    [SerializeField] private PuzzleDoorController _puzzleDoor1;
    [SerializeField] private PuzzleDoorController _puzzleDoor3;
    [SerializeField] private PuzzleDoorController _puzzleDoor4;

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
            _puzzleDoor1.ChangeState();
            _puzzleDoor3.ChangeState();
            _puzzleDoor4.ChangeState();
            _doorProcessing = true;
            _doorCooldown = 1f;
        }
    }
}
