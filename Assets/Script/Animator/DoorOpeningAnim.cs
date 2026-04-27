using DG.Tweening;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class DoorOpeningAnim : MonoBehaviour
{
    [SerializeField] private float _openedPosition;
    [SerializeField] private float _openingDuration;

    [SerializeField] private Vector3 _initialPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _initialPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorOpening()
    {
        transform.DOMoveY(_openedPosition, _openingDuration);
    }

    public void DoorClosing()
    {
        transform.DOMoveY(_initialPosition.y, _openingDuration);
    }
}
