using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour
{
    public GameObject chunk;
    public Vector3 origin;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Space");
        CrossSpawner.spawn(chunk, 3, 10, 6, new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
