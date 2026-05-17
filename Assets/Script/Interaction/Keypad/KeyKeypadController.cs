using DG.Tweening;
using UnityEngine;

public class KeyKeypadController : MonoBehaviour
{
    [SerializeField] private bool _interactable;

    [SerializeField] private ExitManager _exit;
    [SerializeField] private Vector3 _movement;
    [SerializeField] private GameObject _signal;
    [SerializeField] private Material _material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (_interactable)
        {
            _interactable = false;
            _exit.KeyPressed();
            _interactable = false;
            transform.DOMove(transform.position + _movement, 0.5f);
            _signal.GetComponent<MeshRenderer>().material = _material;
        }
    }
}
