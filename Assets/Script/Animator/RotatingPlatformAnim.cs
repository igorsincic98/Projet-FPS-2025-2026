using DG.Tweening;
using UnityEngine;

public class RotatingPlatformAnim : MonoBehaviour
{
    [SerializeField] private float _animDuration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.transform.DORotate(new Vector3(450f, 0f, 0f), _animDuration, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
