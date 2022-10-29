using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public int ChunkId { get; private set; }
    public int HP = 5;
    // Start is called before the first frame update
    void Start()
    {
        HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damage(int ammount)
    {
        HP -= ammount;
        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
