using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AmbushController : MonoBehaviour
{
    [SerializeField] private DoorOpeningAnim doorOpen;
    [SerializeField] private NavMeshAgent navAgent;
    void Start()
    {
        navAgent.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorOpen.DoorOpening();
            navAgent.speed = 5f;
        }
    }
}
