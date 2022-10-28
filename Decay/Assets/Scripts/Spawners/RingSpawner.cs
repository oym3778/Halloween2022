using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public int diameter;
    public int ammount;
    public Vector3 origin;
    public GameObject chunk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCircular(int ammount, int diameter, Vector3 origin)
    {
        transform.position = origin;
        for (float i = 0; i<=ammount; i+=1){
            Vector3 position = origin;
            float angle = i / ammount * 360f;
            angle = angle * Mathf.Deg2Rad;
            Debug.Log(angle);
            Debug.Log(position);
            Debug.Log(origin);
            position.x = Mathf.Cos(angle) * diameter;
            position.y = Mathf.Sin(angle) * diameter;
            position = origin + position;
            Debug.Log(position);
            Instantiate(chunk, position, Quaternion.identity);
        }
    }
}
