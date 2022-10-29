using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour
{
    public GameObject chunk;
    public GameObject levelController;
    public Vector3 origin;
    private GameObject[] chunks;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(chunks.Length > 0)
        {
            for(int i=0; i<chunks.Length; i++)
            {
                bool roundOver = true;
                if (chunks[i].activeSelf)
                {
                    roundOver = false;
                }
            }
        }
    }

    public void StartLevel(int level)
    {
        chunks = RingSpawner.spawn(chunk, 5 + level, 5, new Vector3(0, 0, 0));
    }
}
