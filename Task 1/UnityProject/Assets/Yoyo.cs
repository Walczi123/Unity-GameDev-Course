using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoyo : MonoBehaviour
{

    public float speed = 1f;
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        velocity.y = speed * direction;
        GetComponent<Rigidbody>().velocity = velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Platform (1)" || collision.gameObject.name == "Platform")
        {
            direction *= (-1);
        }
    }
}
