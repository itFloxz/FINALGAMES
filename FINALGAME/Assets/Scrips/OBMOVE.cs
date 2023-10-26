using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Speed at which the object moves
    public Vector2 moveArea = new Vector2(5.0f, 5.0f); // Define the boundaries of the movement area

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float changeDirectionTime = 0.5f; // Time interval to change direction
    private float timer = 0.0f;

    private void Start()
    {
        startPosition = transform.position;
        CalculateNewTargetPosition();
    }

    private void Update()
    {
        // Move the object towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Check if the object has reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            // Wait for a random duration before changing direction
            timer += Time.deltaTime;
            if (timer >= changeDirectionTime)
            {
                CalculateNewTargetPosition();
                timer = 0.0f;
            }
        }
    }

    private void CalculateNewTargetPosition()
    {
        // Calculate a new target position within the defined moveArea
        float randomX = Random.Range(startPosition.x - moveArea.x / 2, startPosition.x + moveArea.x / 2);
        float randomY = Random.Range(startPosition.y - moveArea.y / 2, startPosition.y + moveArea.y / 2);

        targetPosition = new Vector3(randomX, randomY, transform.position.z);
    }
}