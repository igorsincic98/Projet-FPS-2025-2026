using System;
using UnityEngine;

public class PlatformStick : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private Transform platform;
    [SerializeField] private Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(playerTag))
        {
            other.gameObject.transform.parent = platform;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(playerTag))
        {
            other.gameObject.transform.parent = null;
        }
    }

}
