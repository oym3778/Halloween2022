using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector3 position = Vector3.zero;
    Vector3 direction = Vector3.zero;
    Vector3 velocity = Vector3.zero;

    [SerializeField] float speed = 1f;

    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Mouse.current.position.ReadValue();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        velocity = direction * speed * Time.deltaTime;
        position += velocity;
        transform.position = position;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.back, direction);
        }
        //}
        //if (direction == Vector3.down)
        //{
        //    transform.rotation = Quaternion.LookRotation(Vector3.back, direction);
        //}

    }
    //public void OnFire()
    //{
    //    Bullet cloneBullet = new Bullet();
    //    Instantiate(cloneBullet, transform);
    //}
}
