using TMPro;
using UnityEngine;

public class TargetDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshPro _objectiveText;

    [SerializeField] private int _remainingTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _remainingTarget = GameObject.Find("RetractableWall").transform.childCount - 2;
        _objectiveText.text = ("X " + _remainingTarget);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTargetDisplay()
    {
        _objectiveText.text = ("X " + _remainingTarget);
    }
}
