using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSpawner : MonoBehaviour
{

    public static void spawn(GameObject thing, int ammount, int width, int height, Vector3 origin)
    {
        for (int x = -1; x < 2; x += 2)
        {
            for (float i = 0; i < ammount; i++)
            {
                Vector3 position = origin;
                position.x = x * i / ammount * width;
                position.y = 0;
                Instantiate(thing, position, Quaternion.identity);
            }

        }

        for (int y = -1; y < 2; y += 2)
        {
            for (float i = 0; i < ammount; i++)
            {
                Vector3 position = origin;
                position.x = 0;
                position.y = y * i / ammount * height;
                Instantiate(thing, position, Quaternion.identity);
            }
        }
    }
}
