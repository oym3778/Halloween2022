using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector3 position = Vector3.zero;
    Vector3 direction = Vector3.zero;
    Vector3 velocity = Vector3.zero;

    public GameObject player;

    [SerializeField] float speed = 1f;

    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= 1;
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x += 1;
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.y -= 1;
        }
        if (Input.GetKey (KeyCode.W))
        {
            direction.y += 1;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 randompos = new Vector3();
            randompos = this.transform.position;
            randompos.x += Random.Range(-2, 2);
            Instantiate(player, this.transform.position, Quaternion.identity);
        }



        velocity = direction * speed * Time.deltaTime;
        position += velocity;
        transform.position = position;
    }
}
