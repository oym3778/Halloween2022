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
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosOnClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            OnFire();
        }
    }

    public void OnFire()
    {
        if (shootAtMouse)
        {
            Bullet cloneBullet = Instantiate(bullet, this.transform.position, Quaternion.identity);
            m_Bullets.Add(cloneBullet);
            cloneBullet.target = mousePosOnClick;
            cloneBullet.speed = bulletSpeed;

        }
        else if (shootAnotherObject)
        {
            Bullet cloneBullet = Instantiate(bullet, this.transform.position, Quaternion.identity);

            cloneBullet.target = objectToShoot.transform.position;
            cloneBullet.directionToFire = objectToShoot.transform.position - cloneBullet.bulletPos;

            cloneBullet.speed = 1f;
            m_Bullets.Add(cloneBullet);
        }

    }
}
