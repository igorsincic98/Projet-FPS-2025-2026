using DG.Tweening;
using UnityEngine;

public class RotatingPlatformAnim : MonoBehaviour
{
    [SerializeField] private float _animDuration;
    [SerializeField] private float _orientation;

    [SerializeField] private float _rotationOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DORotate(new Vector3(360f * _orientation, _rotationOffset, 0), _animDuration, RotateMode.LocalAxisAdd).SetEase(Ease.Linear)
            .SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
    }

}
