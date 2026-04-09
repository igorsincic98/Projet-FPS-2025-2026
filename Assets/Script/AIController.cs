using System;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private float speed;
    [SerializeField] private float minDistance;
    [SerializeField] private float maxDistance;
    [SerializeField] private GameObject origin;
    [SerializeField] private float hitCooldown;
    [SerializeField] private int damageAmount;
    [SerializeField] private NavMeshAgent navAgent;
    private void Start()
    {
    }

    private void Update()
    {
        /*
        if (Vector3.Distance(transform.position, player.position) > minDistance &&
            Vector3.Distance(transform.position, player.position) < maxDistance)
        {
            transform.LookAt(player);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            transform.LookAt(origin.transform);
            if (Vector3.Distance(transform.position, origin.transform.position) > minDistance)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
            
        }
        */

        if (hitCooldown > 0f)
        {
            hitCooldown -= Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && hitCooldown <= 0f)
        {
            other.gameObject.GetComponent<HealthManager>().TakeDamage(damageAmount);
            hitCooldown = 3f;
        }
    }

    private void GoToTarget()
    {
        navAgent.SetDestination(spawnPoint.transform.position);
    }
}
