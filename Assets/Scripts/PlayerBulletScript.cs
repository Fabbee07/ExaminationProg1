using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the object moves
    public int damageAmount = 1; // Amount of damage the object deals
    public float bulletLifetime = 7f; // Time in seconds before the bullet disappears

    void Update()
    {
        // Move the object along the positive X-axis
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Destroy the bullet after the specified lifetime
        Destroy(gameObject, bulletLifetime);
    }

    // Triggered when something collides with this object
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the "Enemy" tag
        if (other.CompareTag("Enemy"))
        {
            // Get the EnemyHealth component from the collided enemy object
            EnemyHp enemyHealth = other.GetComponent<EnemyHp>();

            // If the enemy has an EnemyHealth component, reduce its health
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damageAmount);
            }

            // Destroy this object upon collision
            Destroy(gameObject);
        }
    }
}
