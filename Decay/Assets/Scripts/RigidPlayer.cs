using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0,0,0);
        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x += 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direction.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.y -= 1;
        }

        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }

}
