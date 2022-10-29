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

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosOnClick = Input.mousePosition;
            OnFire();
        }
    }

    public void OnFire()
    {
        if (shootAtMouse)
        {
            Bullet cloneBullet = Instantiate(bullet);
            cloneBullet.bulletPos = transform.position;
            m_Bullets.Add(cloneBullet);
            cloneBullet.target = mousePosOnClick;

        }
        else if (shootAnotherObject)
        {
            Bullet cloneBullet = Instantiate(bullet);
            cloneBullet.bulletPos = transform.position;

            cloneBullet.target = objectToShoot.transform.position;
            cloneBullet.directionToFire = objectToShoot.transform.position - cloneBullet.bulletPos;

            cloneBullet.speed = 1f;
            m_Bullets.Add(cloneBullet);
        }

    }
}
