using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script should store the bullets and spawn them in
// Putting this script on a gameobject gives it the abilility to fire
public class BulletSpawner : MonoBehaviour
{
    public List<Bullet> m_Bullets = new List<Bullet>();
    public Bullet bullet;

    public bool shootAnotherObject;
    public bool shootAtMouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFire()
    {
        if (shootAtMouse)
        {
            Bullet cloneBullet = Instantiate(bullet);
            cloneBullet.bulletPos = transform.position;
            cloneBullet.shootAtMouse = true;
            m_Bullets.Add(cloneBullet);
        }

        
    }
}
