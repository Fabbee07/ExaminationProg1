using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the object moves to the left
    public float disappearXPosition = -12f; // X position where the object should disappear

    void Update()
    {
        // Move the object left in each frame
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // Check if the object's x position is less than or equal to the specified position
        if (transform.position.x <= disappearXPosition)
        {
            gameObject.SetActive(false); // Deactivate the GameObject to make it disappear
        }
    }
}
