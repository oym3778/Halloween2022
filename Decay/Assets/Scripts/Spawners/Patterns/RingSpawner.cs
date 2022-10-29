using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public static GameObject[] spawn(GameObject thing, int ammount, int diameter, Vector3 origin)
    {
        GameObject[] spawns = new GameObject[ammount];
        for (float i = 0; i<ammount; i+=1){
            Vector3 position = origin;
            float angle = i / ammount * 360f;
            angle = angle * Mathf.Deg2Rad;
            position.x = Mathf.Cos(angle) * diameter;
            position.y = Mathf.Sin(angle) * diameter;
            position = origin + position;
            spawns[(int)i] = Instantiate(thing, position, Quaternion.identity);
        }
        return spawns;
    }
}
