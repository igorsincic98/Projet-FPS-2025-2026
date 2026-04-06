using System;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private float maxHealth, currentHealth;
    [SerializeField] private RectTransform healthBar;

    void Awake()
    {
        currentHealth = maxHealth;
    }
    
    void SetHealthBar()
    {
        healthBar.sizeDelta = new Vector2((currentHealth / maxHealth) * healthBar.sizeDelta.x, healthBar.sizeDelta.y);
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            
        }
    }

}
