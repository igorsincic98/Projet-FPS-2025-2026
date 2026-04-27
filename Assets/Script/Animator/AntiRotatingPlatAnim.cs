using DG.Tweening;
using UnityEngine;

public class AntiRotatingPlatAnim : MonoBehaviour
{
    [SerializeField] private float _animDuration;
    [SerializeField] private float _orientationx;
    [SerializeField] private float _orientationy;
    [SerializeField] private float _orientationz;
    [SerializeField] private float _anglex;
    [SerializeField] private float _angley;
    [SerializeField] private float _anglez;

    [SerializeField] private float _rotationOffset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        transform.DORotate(new Vector3(360f * _orientationx, 360f * _orientationy, 360f * _orientationz), _animDuration, RotateMode.LocalAxisAdd)
            .SetEase(Ease.Linear)
            .SetLoops(-1);
    */
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(_anglex, _angley, _anglez,0f);
    }
}
