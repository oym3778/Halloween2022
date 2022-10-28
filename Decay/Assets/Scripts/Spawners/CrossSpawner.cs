using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSpawner : MonoBehaviour
{
    public int length;
    public int ammount;
    public Vector3 origin;
    public GameObject chunk;

    void SpawnCircular(int ammount, int length, Vector3 origin)
    {
        transform.position = origin;
        for (int x = -1; x < 2; x += 2)
        {
            for(int y = -1; y < 2; y += 2)
            {
                for(float i = 0; i < ammount; i++)
                {
                    Vector3 position = origin;
                    position.x = x * i / ammount * length;
                    position.y = y * i / ammount * length;
                    Instantiate(chunk, position, Quaternion.identity);
                }

            }
            
        }
    }
}
