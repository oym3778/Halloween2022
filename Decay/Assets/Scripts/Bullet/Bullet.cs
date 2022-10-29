using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


// Hold the bullet asset and all transform properties of that bullet
// Handle if targeting mouse or another gameobject

public class Bullet : MonoBehaviour
{
    public Vector3 bulletPos = Vector3.zero;
    Vector3 bullVelocity = Vector3.zero;
    public Vector3 directionToFire = Vector3.right;

    public float speed = 15f;

    public Vector3 target;
    private Vector3 diff;

    public bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.transform.position);
        Debug.Log(target);
        diff = target - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Everything should still run movement, however
        // direction will be changed based on if fireing at the mouse or at another object,
        // that is handled in the Bullet Spawner
        bullVelocity = diff / diff.magnitude * speed * Time.deltaTime;
        bulletPos += bullVelocity;
        transform.position = bulletPos;

    }



}
