using DG.Tweening;
using UnityEngine;

public class UpDownAnim : MonoBehaviour
{
    [SerializeField] private float _timeOffSet;
    [SerializeField] private int _timerMax;
    [SerializeField] private float _timer;
    [SerializeField] private int _phase;

    [SerializeField] private float _duration;

    [SerializeField] private float _moveDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_timeOffSet > 0f)
        {
            _timeOffSet -= Time.deltaTime;
        }

        if (_timer > 0f)
        {
            _timer -= Time.deltaTime;
        }
        if (_timeOffSet <= 0f && _timer <= 0f)
        {
            gameObject.transform.transform.DOMoveY((transform.position.y - (_moveDistance * _phase)), _duration).SetEase(Ease.Linear);
            _timer = _timerMax;
            _phase *= -1;
        }
    }
}
