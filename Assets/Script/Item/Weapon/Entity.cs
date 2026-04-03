using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour

{
    [SerializeField] private float startingHealth;
    [SerializeField] private UnityEvent signal;
    private float health;
    
    void Start()
    {
        health = startingHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            signal.Invoke();
            Destroy(gameObject);
        }
    }
    
}
