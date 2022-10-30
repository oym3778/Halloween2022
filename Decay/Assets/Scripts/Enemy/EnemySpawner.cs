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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Time.time > nextSpawn)
        //{
        //    nextSpawn = Time.time + spawnRate;

        //    Enemy cloneEnemy = Instantiate(enemy, transform);
        //    float tempX = Random.Range(cloneEnemy.m_PhysicsObject.width * -1, cloneEnemy.m_PhysicsObject.width);
        //    float tempY = Random.Range(cloneEnemy.m_PhysicsObject.height * -1, cloneEnemy.m_PhysicsObject.height);
        //    cloneEnemy.m_PhysicsObject.Position = new Vector3(tempX, tempY, -0.1292487f);
        //    spawns.Add(cloneEnemy);
        //}
    }
}
