using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float bulletVelocity = 10f; // Velocity of the projectile
    public int damageAmount = 10; // Amount of damage the projectile deals

    void Update()
    {
        // Move the projectile along the negative X-axis
        transform.Translate(Vector3.left * bulletVelocity * Time.deltaTime);

        // Check if the projectile's x position is less than or equal to -12
        if (transform.position.x <= -12f)
        {
            Destroy(gameObject); // Destroy the projectile if it reaches -12x
        }
    }

    // Triggered when the object collides with another object
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Get the PlayerHealth component from the collided player object
            PlayerHp playerHealth = other.GetComponent<PlayerHp>();

            // If the player has a PlayerHealth component, reduce its health
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }

            // Destroy this projectile upon collision with the player
            Destroy(gameObject);
        }
    }
}
