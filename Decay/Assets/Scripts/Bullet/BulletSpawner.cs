using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// This script should store the bullets and spawn them in
// Putting this script on a gameobject gives it the abilility to fire
public class BulletSpawner : MonoBehaviour
{
    public List<Bullet> m_Bullets = new List<Bullet>();
    public Bullet bullet;

    public bool shootAnotherObject;

    public bool shootAtMouse;
    public Vector3 mousePosOnClick;

    public GameObject objectToShoot;

    // Start is called before the first frame update
    void Start()
    {
        //if (Mouse.current.position.ReadValue() != null)
        //{
        //    Debug.Log("This is null");
        //}
        //mousePosOnClick = Mouse.current.position.ReadValue();
        //mousePosOnClick = Camera.main.ScreenToWorldPoint(mousePosOnClick);
        //mousePosOnClick.z = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //mousePosOnClick = Mouse.current.position.ReadValue();
    }

    public void OnFire()
    {
        if (shootAtMouse)
        {
            Bullet cloneBullet = Instantiate(bullet);
            cloneBullet.bulletPos = transform.position;
            cloneBullet.shootAtMouse = true;
            cloneBullet.shootAnotherObject = false;
            m_Bullets.Add(cloneBullet);
            cloneBullet.mousePosOnClick = mousePosOnClick;

        }
        else if (shootAnotherObject)
        {
            Bullet cloneBullet = Instantiate(bullet);
            cloneBullet.bulletPos = transform.position;
            cloneBullet.shootAtMouse = false;
            cloneBullet.shootAnotherObject = true;

            cloneBullet.objectToShootB = objectToShoot.transform.position;
            cloneBullet.directionToFire = objectToShoot.transform.position - cloneBullet.bulletPos;

            cloneBullet.speed = 1f;
            m_Bullets.Add(cloneBullet);
        }

    }
}
