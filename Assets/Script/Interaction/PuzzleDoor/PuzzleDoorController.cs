using DG.Tweening;
using UnityEngine;

public class PuzzleDoorController : MonoBehaviour
{
    [SerializeField] private int _phase;

    [SerializeField] private Vector3 _initialPosition;
    [SerializeField] private Vector3 _initialScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _phase = 1; 
        _initialPosition = transform.position;
        _initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState()
    {
        switch (_phase)
        {


            case 1 :
            {
                Debug.Log("Up");
                transform.DOMoveY(transform.position.y + 3f, 1f).SetEase(Ease.Linear);
                transform.DOScaleY(0f, 1f).SetEase(Ease.Linear);
                _phase *= -1;
                break;
            }

            case -1 :
            {
                Debug.Log("Down");
                transform.DOMoveY(_initialPosition.y, 1f).SetEase(Ease.Linear);
                transform.DOScaleY(_initialScale.y, 1f).SetEase(Ease.Linear);
                _phase *= -1;
                break;
            }
        }
    }
}
