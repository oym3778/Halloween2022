using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidEnemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform target;
    public int speed;
    private Vector3 diff;
    private float distance;

    private float angle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        diff = target.position - this.transform.position;
        distance = diff.magnitude;

        rb.velocity = diff / distance * speed;
    }
}
