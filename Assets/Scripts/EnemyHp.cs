using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100; // Enemy health points
    public int scoreValue = 100; // Score value when this enemy is destroyed
    public ScoreManager scoreManager; // Reference to the ScoreManager script

    // Method to handle enemy damage
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die();
        }
    }

    // Method to handle enemy death
    void Die()
    {
        // Increase the score upon enemy death
        if (scoreManager != null)
        {
            scoreManager.IncreaseScore(scoreValue);
        }

        // Destroy the enemy object
        Destroy(gameObject);
    }
}
