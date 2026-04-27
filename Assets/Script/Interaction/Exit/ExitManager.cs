using DG.Tweening;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    [SerializeField] private int _buttonPushed;
    [SerializeField] private GameObject _exitDoorLeft;
    [SerializeField] private GameObject _exitDoorRight;
    [SerializeField] private float _duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KeyPressed()
    {
        if (_buttonPushed < 1)
        {
            _buttonPushed++;
        }

        if (_buttonPushed >= 1)
        {
            ExitOpens();
        }
    }

    public void ExitOpens()
    {
        _exitDoorLeft.transform.DOMoveY(_exitDoorLeft.transform.position.y + 5f, _duration);
        _exitDoorRight.transform.DOMoveY(_exitDoorLeft.transform.position.y - 5f, _duration);

    }
}
