using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRadiusSpawner : MonoBehaviour
{
    public static void spawn(GameObject thing, int ammount, int diameter, Vector3 origin)
    {
        for(int i = 0; i < ammount; i++) {
            Vector3 position = origin; 
            float angle = Random.value * 360 * Mathf.Deg2Rad;
            float distance = Random.value * diameter;
            position.x = Mathf.Cos(angle) * distance;
            position.y = Mathf.Sin(angle) * distance;
            Instantiate(thing, position, Quaternion.identity);
        }
    }
}
