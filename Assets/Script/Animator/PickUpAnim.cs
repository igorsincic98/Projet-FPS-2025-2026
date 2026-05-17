using DG.Tweening;
using UnityEngine;

public class PickUpAnim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(gameObject != null)
        {
            transform.DOMoveY(transform.position.y + 1f, 2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
            transform.DORotate(new Vector3(0, transform.rotation.y + 360f, 0), 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
