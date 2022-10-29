using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRadiusSpawner : MonoBehaviour
{
    public static GameObject[] spawn(GameObject thing, int ammount, int diameter, Vector3 origin)
    {
        GameObject[] spawns = new GameObject[ammount];
        for(int i = 0; i < ammount; i++) {
            Vector3 position = origin; 
            float angle = Random.value * 360 * Mathf.Deg2Rad;
            float distance = Random.value * diameter;
            position.x = Mathf.Cos(angle) * distance;
            position.y = Mathf.Sin(angle) * distance;
            spawns[i] = Instantiate(thing, position, Quaternion.identity);
        }
        return spawns;
    }
}
