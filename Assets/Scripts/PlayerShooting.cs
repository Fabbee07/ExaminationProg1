using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public Transform firePoint; // Point where the shots originate

    public float bulletVelocity = 10f; // Velocity of the bullets
    public float fireRate = 0.5f; // Default shots per second
    private float nextFireTime = 0f; // Next allowed shot time

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFireTime)
        {
            FireProjectile();
            nextFireTime = Time.time + 1f / fireRate; // Update the next allowed shot time based on fireRate
        }
    }

    void FireProjectile()
    {
        // Create the projectile at the firePoint's position and rotation
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Set the velocity of the projectile
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * bulletVelocity; // Travel along the X-axis (change Vector2.right to Vector2.left if needed)
    }

    // Method to change the fire rate
    public void ChangeFireRate(float newFireRate)
    {
        fireRate = newFireRate;
    }
}
