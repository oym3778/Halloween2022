using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    Vector3 bulletPos = Vector3.zero;
    Vector3 bullVelocity = Vector3.zero;
    Vector3 direction = Vector3.zero;

    public float speed = 1f;

    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        bulletPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Mouse.current.position.ReadValue();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        direction = mousePos.normalized;
        direction.y = 0;
        direction.x = 0;
        //bullVelocity = direction * speed * Time.deltaTime;
        transform.rotation = Quaternion.EulerRotation(direction);

        bulletPos += direction;
        
        //transform.position = bulletPos;
    }
    
}
