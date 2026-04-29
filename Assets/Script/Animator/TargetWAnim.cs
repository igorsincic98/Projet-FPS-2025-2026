using DG.Tweening;
using UnityEngine;

public class TargetWAnim : MonoBehaviour
{
    private Sequence wSequence;
    [SerializeField] private float _animSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sequence wSequence = DOTween.Sequence().SetLoops(-1, LoopType.Yoyo);
        wSequence.Append(transform.DOMove(new Vector3(transform.position.x - 5f, transform.position.y - 4f, transform.position.z),
            _animSpeed).SetEase(Ease.Linear).SetLink(gameObject));
        wSequence.Append(transform.DOMove(new Vector3(transform.position.x - 10f, transform.position.y, transform.position.z),
            _animSpeed).SetEase(Ease.Linear).SetLink(gameObject));
        wSequence.Append(transform.DOMove(new Vector3(transform.position.x - 15f, transform.position.y - 4f, transform.position.z),
            _animSpeed).SetEase(Ease.Linear).SetLink(gameObject));
        wSequence.Append(transform.DOMove(new Vector3(transform.position.x - 20f, transform.position.y, transform.position.z),
            _animSpeed).SetEase(Ease.Linear).SetLink(gameObject));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimStop()
    {
        Debug.Log("Stop Received");
        wSequence.SetLoops(0);
        wSequence.Complete();
        wSequence.Kill();
        Debug.Log("Tween Killed");
    }
}
