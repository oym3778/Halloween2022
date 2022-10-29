using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSpawner : MonoBehaviour
{

    public static GameObject[] spawn(GameObject thing, int ammount, int width, int height, Vector3 origin)
    {
        GameObject[] spawns = new GameObject[ammount];
        int added = 0;
        for (int x = -1; x < 2; x += 2)
        {
            for (float i = 0; i < ammount; i++)
            {
                Vector3 position = origin;
                position.x = x * i / ammount * width;
                position.y = 0;
                spawns[added] = Instantiate(thing, position, Quaternion.identity);
                added++;
            }

        }

        for (int y = -1; y < 2; y += 2)
        {
            for (float i = 0; i < ammount; i++)
            {
                Vector3 position = origin;
                position.x = 0;
                position.y = y * i / ammount * height;
                spawns[added] = Instantiate(thing, position, Quaternion.identity);
                added++;
            }
        }
        return spawns;
    }
}
