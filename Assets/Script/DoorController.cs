using DG.Tweening;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private int _targetObjective;
    [SerializeField] private float _moveDistance;
    [SerializeField] private float _scaleDistance;
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
        if (transform.childCount <= _targetObjective)
        {
            Debug.Log("Objective done");
            transform.DOMoveY(transform.position.y + _moveDistance, 1f);
            transform.DOScaleY(transform.localScale.y + _scaleDistance, 1f);
            Debug.Log("Has moved");
        }
    }
    
}
