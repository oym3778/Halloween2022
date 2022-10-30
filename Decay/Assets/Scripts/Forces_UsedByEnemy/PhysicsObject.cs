using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    Vector3 position = Vector3.zero;
    Vector3 acceleration = Vector3.zero;
    Vector3 velocity = Vector3.zero;
    
    [SerializeField] float mass = 1f;

    // Not used for calculating direction object should move
    // Instead...Could be used to rotate an object
    Vector3 direction = Vector3.zero;

    public float width;
    public float height;

    // Properties
    public Vector3 Position
    {
        get { return position; }
        set { position = value; }
    }
    public Vector3 Acceleration
    {
        get { return acceleration; }
    }
    public Vector3 Velocity
    {
        get { return velocity; }
    }

    // Start is called before the first frame update
    void Start()
    {
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Bounce();

        // Play with these values a bit, why is it += instead of = as
        // it usually was for vector based movement
        velocity += acceleration * Time.deltaTime;
        position += velocity * Time.deltaTime;
        

        if (velocity.sqrMagnitude > Mathf.Epsilon)
        {
            // Grab current direction from velocity  - New
            direction = velocity.normalized;
        }
        position.z = -0.17f;
        transform.position = position;

        acceleration = Vector3.zero;

        transform.rotation = Quaternion.LookRotation(Vector3.back, direction);
    }

    public void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }

    public void Bounce()
    {
        // Right
        if (position.x > width && velocity.x > 0)
        {
            velocity.x *= -1f;
        }
        // Left
        if (position.x < width * -1 && velocity.x < 0)
        {
            velocity.x *= -1f;
        }
        // Up
        if (position.y > height && velocity.y > 0)
        {
            velocity.y *= -1f;
        }
        // Bottom
        if (position.y < height * -1 && velocity.y < 0)
        {
            velocity.y *= -1f;
        }
    }
}
