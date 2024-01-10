using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHp : MonoBehaviour
{
    public int health = 100; // Enemy health points
    public int scoreValue = 100; // Score value when this enemy is destroyed
    public ScoreManager scoreManager; // Reference to the ScoreManager script
    public string VictoryScene;

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

        SceneManager.LoadScene(VictoryScene);

        // Increase the score upon enemy death
        if (scoreManager != null)
        {
            scoreManager.IncreaseScore(100);
        }

        // Destroy the enemy object
        Destroy(gameObject);
    }
}
