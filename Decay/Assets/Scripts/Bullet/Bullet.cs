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
    Vector3 direction = Vector3.zero;

    public float speed = 1f;

    public Vector3 mouseCurrentPos;
    public Vector3 mousePosOnClick;

    public bool shootAnotherObject;
    public bool shootAtMouse;
    public bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // Everything should still run movement, however
        // direction will be changed based on the respective if statements
        //if (shootAnotherObject)
        //{
        //    ShootToObject();
        //    direction = ;
        //}
        //else if (shootAtMouse)
        //{
        ShootToMouse();
        direction = mouseCurrentPos;
        //}


        bullVelocity = direction * speed * Time.deltaTime;
        bulletPos += bullVelocity;
        transform.position = bulletPos;

    }
    private void ShootToMouse()
    {
        mouseCurrentPos = Mouse.current.position.ReadValue();
        mouseCurrentPos = Camera.main.ScreenToWorldPoint(mouseCurrentPos);
        mouseCurrentPos.z = 0;

        direction = mouseCurrentPos;
    }
    private void ShootToObject()
    {
        direction = Vector3.zero;
    }


    private Vector3 GetMouseClickPos()
    {
        return transform.position;
    }



}
