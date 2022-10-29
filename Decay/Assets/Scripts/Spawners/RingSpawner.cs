using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public static void spawn(GameObject thing, int ammount, int diameter, Vector3 origin)
    {
        for (float i = 0; i<=ammount; i+=1){
            Vector3 position = origin;
            float angle = i / ammount * 360f;
            angle = angle * Mathf.Deg2Rad;
            position.x = Mathf.Cos(angle) * diameter;
            position.y = Mathf.Sin(angle) * diameter;
            position = origin + position;
            Instantiate(thing, position, Quaternion.identity);
        }
    }
}
