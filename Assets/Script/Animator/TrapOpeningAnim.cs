using DG.Tweening;
using UnityEngine;

public class TrapOpeningAnim : MonoBehaviour
{
    [SerializeField] private GameObject trapDoorLeft;
    [SerializeField] private GameObject trapDoorRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrapOpening()
    {
        trapDoorLeft.transform.DORotate(new Vector3(0f,0f,-180f), 1f);
        trapDoorLeft.transform.DOLocalMove(new Vector3(-2.04f, -1.8f, 0f), 1f);
        trapDoorRight.transform.DORotate(new Vector3(0f,0f,0f), 1f);
        trapDoorRight.transform.DOLocalMove(new Vector3(8.11f, -2.25f, 0f), 1f);
    }
}
