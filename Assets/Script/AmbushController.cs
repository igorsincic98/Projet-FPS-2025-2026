using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AmbushController : MonoBehaviour
{
    [SerializeField] private DoorOpeningAnim doorOpen;
    [SerializeField] private NavMeshAgent navAgent;
    [SerializeField] private bool _triggered;
    void Start()
    {
        navAgent.speed = 0f;
        _triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player" && navAgent != null && _triggered == false)
        {
            doorOpen.DoorOpening();
            navAgent.speed = 5f;
            _triggered = true;
        }
    }
}
