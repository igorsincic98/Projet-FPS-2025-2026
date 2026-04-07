using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private float maxHealth, currentHealth;
    [SerializeField] private RectTransform healthBar;
    [SerializeField] private GameObject gameOverScreen;

    void Awake()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.sizeDelta = new Vector2((currentHealth / maxHealth) * healthBar.sizeDelta.x, healthBar.sizeDelta.y);
        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Retry()
    {
        Time.timeScale = 1;
        gameOverScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
