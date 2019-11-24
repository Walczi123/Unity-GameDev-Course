using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
	public float speed = 1;
	public float jumpSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void OnEnable()
	{
		Debug.Log("enable");
	}

	// Update is called once per frame
	void Update()
    {
		Vector3 velocity = GetComponent<Rigidbody>().velocity;
		velocity.x = speed;
		if (Input.GetMouseButtonDown(0))
		{
			velocity.y = jumpSpeed;
		}
		GetComponent<Rigidbody>().velocity = velocity;
    }

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Finish")
		{
			Debug.Log("You win!");
		}
		else
		{
			Debug.Log("You lose!");
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			transform.position = Vector3.zero;
            var c = GameObject.FindGameObjectsWithTag("Coins");
            c.

        }
	}
}
