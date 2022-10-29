using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 enemyPos = Vector3.zero;
    Vector3 enemyVelocity = Vector3.zero;
    Vector3 enemyDirection = Vector3.zero;

    public float enemySpeed = 5f;

    private float nextFire = 0.0f;
    public float fireRate = 0.5f;

    private BulletSpawner bulletSpawner;
    private Bullet bullet;
    private GameObject objectToShoot;

    // Start is called before the first frame update
    void Start()
    {
        enemyPos = transform.position;
        bulletSpawner = GetComponent<BulletSpawner>();
        bullet = bulletSpawner.bullet;
        objectToShoot = bulletSpawner.objectToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        enemyVelocity = enemyDirection * enemySpeed * Time.deltaTime;
        enemyPos += enemyVelocity;
        transform.position = enemyPos;

        //if (Time.time > nextFire)
        //{
        //    nextFire = Time.time + fireRate;
        //    Bullet cloneBullet = Instantiate(bullet);
        //    cloneBullet.bulletPos = transform.position;
        //    cloneBullet.shootAtMouse = false;
        //    cloneBullet.shootAnotherObject = true;
        //    cloneBullet.objectToShootB = objectToShoot.transform.position;
        //    cloneBullet.directionToFire = objectToShoot.transform.position - cloneBullet.bulletPos;

        //    cloneBullet.speed = 1f;
        //    bulletSpawner.m_Bullets.Add(cloneBullet);
        //}
    }
}