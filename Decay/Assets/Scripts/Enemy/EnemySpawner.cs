using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float nextSpawn = 0f;
    public float spawnRate = .5f;
    public List<Enemy> spawns = new List<Enemy>();
    public Enemy enemy;
    public Player player;
    public float tempX;
    public float tempY;

    public int totalPoints;
    public GameObject pointsWritten;

    public BulletSpawner bulletSpawner;

    List<Enemy> enemiesToRemove = new List<Enemy>();
    List<Bullet> bulletsToRemove = new List<Bullet>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            Enemy cloneEnemy = Instantiate(enemy, transform);
            PhysicsObject test = cloneEnemy.GetComponent<PhysicsObject>();

            tempX = Random.Range(-player.position.x * 5, player.position.x * 5);
            tempY = Random.Range(-player.position.y * 5, player.position.y * 5);

            Steering_Seek seeker = cloneEnemy.GetComponent<Steering_Seek>();
            seeker.target = player.gameObject;

            // jsut spawn them a certain distance away from player
            cloneEnemy.m_PhysicsObject.position = new Vector3(tempX, tempY, -0.1292487f);
            spawns.Add(cloneEnemy);
        }

        for (int i = 0; i < spawns.Count; i++)
        {
            for (int z = 0; z < bulletSpawner.m_Bullets.Count; z++)
            {
                if (CircleCollision(bulletSpawner.m_Bullets[z], spawns[i]))
                {
                    totalPoints += spawns[i].points;
                    spawns[i].isActive = false;
                    bulletSpawner.m_Bullets[z].isActive = false;

                    enemiesToRemove.Add(spawns[i]);
                    bulletsToRemove.Add(bulletSpawner.m_Bullets[z]);
                    pointsWritten.GetComponent<TextMesh>().text = $"Score: {totalPoints}";
                    
                }
            }
        }

        // Handles Deletion of enemies who have collided and are no longer active
        for (int i = 0; i < enemiesToRemove.Count; i++)
        {
            if (spawns.Contains(enemiesToRemove[i]))
            {
                spawns.Remove(enemiesToRemove[i]);
                Destroy(enemiesToRemove[i].gameObject);
            }
        }
        // Handles Deletion of Bullets who have collided and are no longer active
        for (int i = 0; i < bulletsToRemove.Count; i++)
        {
            if (bulletSpawner.m_Bullets.Contains(bulletsToRemove[i]))
            {
                bulletSpawner.m_Bullets.Remove(bulletsToRemove[i]);
                Destroy(bulletsToRemove[i].gameObject);
            }
        }

    }

    private bool CircleCollision(Bullet obj1, Enemy obj2)
    {
        // if the distance between centers of each object is less
        // than the summed raduis of both objects, there is a collision
        float distance = Mathf.Sqrt(Mathf.Pow(obj1.bulletPos.x - obj2.m_PhysicsObject.position.x, 2)
            + Mathf.Pow(obj1.bulletPos.y - obj2.m_PhysicsObject.position.y, 2));
        if (distance < obj1.radius + obj2.radius)
        {
            return true;
        }
        // Else no collision
        else
        {
            return false;
        }
    }
}
