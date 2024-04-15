using UnityEngine;
using System;

public class PlayerMovment : MonoBehaviour
{
    // Attributes
    public float acceleration = 10f;  // Acceleration of the vehicle
    public float handling = 2f;        // Handling of the vehicle (how fast it turns)
    public float topSpeed = 10f;      // Top speed of the vehicle
    public float durability = 100f;    // Durability of the vehicle

    // Internal variables
    private float currentSpeed = 0f;
    private Rigidbody rb;          // Rigidbody component of the vehicle

    private bool followingPlayer = false; // Flag to indicate if the vehicle is following the player
    
    private GameObject player;            // Reference to the player vehicle

    public GameObject enemy;
    
    public String axisNameHorizontal,axisNameVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the vehicle
        player = this.gameObject;
    }

    void Update()
    {
        if (followingPlayer && player != null)
        {
            // Calculate direction to move towards the player
            Vector3 direction = (player.transform.position - transform.position).normalized;

            // Calculate rotation to face the player
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            // Smoothly rotate towards the player
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, handling * Time.deltaTime);

            // Move towards the player's position
            rb.MovePosition(rb.position + transform.forward * currentSpeed * Time.deltaTime);
        }
        else
        {
            // Normal vehicle movement code
            // Input for forward and backward movement
            float moveInput = Input.GetAxis(axisNameVertical);

            // Input for left and right rotation
            float turnInput = Input.GetAxis(axisNameHorizontal);

            // Calculate acceleration based on input
            currentSpeed += moveInput * acceleration * Time.deltaTime;

            // Clamp speed to stay within the top speed
            currentSpeed = Mathf.Clamp(currentSpeed, -topSpeed, topSpeed);

            // Calculate movement direction based on current speed and vehicle's forward direction
            Vector3 movement = transform.up * currentSpeed * Time.deltaTime;

            // Move the vehicle
            rb.MovePosition(rb.position + movement);

            // Calculate rotation based on turn input and handling
            float turn = turnInput * handling * Time.deltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, 0f, turn);

            // Rotate the vehicle
            rb.MoveRotation(rb.rotation * turnRotation);
        }
    }

    

    void IncreaseSpeed(float amount)
    {
        // Increase the top speed of the vehicle
        topSpeed += amount;
    }

    void IncreaseDurability(float amount)
    {
        // Increase the durability of the vehicle
        durability += amount;
    }

    void StartFollowingPlayer()
    {
        followingPlayer = true; // Set flag to start following the player
    }
}

// Enum for different types of power-ups


public class PowerUp : MonoBehaviour
{
    public PowerUpType type; // Type of the power-up
    public float amount;     // Amount by which the power-up affects the vehicle (e.g., speed boost amount, durability boost amount)
    public void Negate()
    {
        
    }
}

public enum PowerUpType
{
    SpeedBoost,
    DurabilityBoost,
    FollowPlayer,
    PhaseThroughEnemies, // New power-up type
    // Add more types if needed
}
