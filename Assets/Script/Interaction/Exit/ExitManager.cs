using DG.Tweening;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    [SerializeField] private int _buttonPushed;
    [SerializeField] private GameObject _exitDoorLeft;
    [SerializeField] private GameObject _exitDoorRight;
    [SerializeField] private float _duration;
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

    public void KeyPressed()
    {
        if (_buttonPushed < 2)
        {
            _buttonPushed++;
            
            Debug.Log("Button Pushed");
            
        }

        if (_buttonPushed >= 2)
        {
            ExitOpens();
        }
    }

    public void ExitOpens()
    {
        if (_interactable)
        {
            _exitDoorLeft.transform.DOMoveX(_exitDoorLeft.transform.position.x - 5f, _duration);
            _exitDoorRight.transform.DOMoveX(_exitDoorRight.transform.position.x + 5f, _duration);
        }
    }
}
