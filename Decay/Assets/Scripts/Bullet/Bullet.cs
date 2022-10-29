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

    public Vector3 mousePosOnClick;

    public bool shootAnotherObject = false;
    public bool shootAtMouse = false;

    public bool isActive = true;

    public Vector3 objectToShootB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Everything should still run movement, however
        // direction will be changed based on if fireing at the mouse or at another object,
        // that is handled in the Bullet Spawner

        bullVelocity = directionToFire * speed * Time.deltaTime;
        bulletPos += bullVelocity;
        transform.position = bulletPos;

    }
    //private void ShootToMouse(Vector3 mousePosition)
    //{
    //    directionToFire = mousePosOnClick.normalized;
    //}
    //public void ShootToObject(Vector3 target)
    //{

    //    //float angle = Mathf.Atan2(target.y - transform.position.y, target.x - transform.position.x);
    //    float angle = Mathf.Atan2(target.y, target.x) - Mathf.Atan2(transform.position.y, transform.position.x);

    //}


    //private Vector3 GetMouseClickPos()
    //{
    //    return transform.position;
    //}



}
