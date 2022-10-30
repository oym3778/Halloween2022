using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float nextSpawn = 0f;
    public float spawnRate = .5f;
    List<Enemy> spawns = new List<Enemy>();
    public Enemy enemy;
    public Player player;
    public float tempX;
    public float tempY;

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
    }
}
