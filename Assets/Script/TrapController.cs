using System;
using Unity.VisualScripting;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    [SerializeField] private Animator trap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            trap.Play("Open");
        }
    }
}
