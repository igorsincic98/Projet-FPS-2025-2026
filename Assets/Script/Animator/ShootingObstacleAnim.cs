using DG.Tweening;
using UnityEngine;

public class ShootingObstacleAnim : MonoBehaviour
{
    Sequence _obstacleSequence;
    [SerializeField] private float _duration;
    [SerializeField] private float _height;
    [SerializeField] private float _length;
    [SerializeField] private float _pause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _obstacleSequence = DOTween.Sequence().SetLoops(-1, LoopType.Yoyo);
        _obstacleSequence.AppendInterval(_pause);
        _obstacleSequence.Append(transform.DOMove(new Vector3(transform.position.x + _length, transform.position.y + _height, transform.position.z), _duration));
        _obstacleSequence.Insert(2, transform.DOScaleX(0f, _duration));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
