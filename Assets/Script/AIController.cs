using System;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private float speed;
    [SerializeField] private float minDistance;
    [SerializeField] private float maxDistance;
    [SerializeField] private GameObject origin;
    private void Start()
    {
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) >= minDistance &&
            Vector3.Distance(transform.position, player.position) <= maxDistance)
        {
            transform.LookAt(player);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            transform.LookAt(origin.transform);
            if (Vector3.Distance(transform.position, origin.transform.position) >= minDistance)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }
    }
}
