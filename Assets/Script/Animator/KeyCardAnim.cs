using DG.Tweening;
using UnityEngine;

public class KeyCardAnim : MonoBehaviour
{
    void Start()
    {
        if(gameObject != null)
        {
            transform.DOMoveY(transform.position.y + 1f, 2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
            transform.DORotate(new Vector3(0, 0, transform.rotation.y + 360f), 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental); 
        }
    }
}
