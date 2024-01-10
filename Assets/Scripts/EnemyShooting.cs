using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public Transform firePoint; // Point where the shots originate

    public float spawnInterval = 3f; // Time interval between spawning shots

    private float nextSpawnTime = 0f; // Next allowed spawn time

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnProjectile();
            nextSpawnTime = Time.time + spawnInterval; // Update the next allowed spawn time
        }
    }

    void SpawnProjectile()
    {
        // Create the projectile at the firePoint's position and rotation
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Add velocity or force to the spawned projectile if needed

        // Destroy the projectile after a certain time
        Destroy(newProjectile, 5.0f);
    }

    // Triggered when something collides with the projectile
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
                playerHealth.TakeDamage(10); // Adjust the damage amount as needed
            }

            // Destroy the projectile upon collision with the player
            Destroy(gameObject);
        }
    }
}
