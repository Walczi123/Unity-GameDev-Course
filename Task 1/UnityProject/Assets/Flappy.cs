using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
	public float speed = 1;
	public float jumpSpeed = 4;
    private int coins = 0;
    private Transform[] children;

    // Start is called before the first frame update
    void Start()
    {
        GameObject parent = GameObject.Find("AllCoins");
        children = parent.GetComponentsInChildren<Transform>();
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
            //GetComponent<Rigidbody>().velocity = Vector3.zero;
            //transform.position = Vector3.zero;
        }
		else
		{
            if(collision.gameObject.transform.parent != null ) //collision.gameObject.transform.parent.name == "AllCoins")
            {
                collision.gameObject.SetActive(false);
                Debug.Log("Amount of collected coins "+(++coins));
            }
            else
            {
                Debug.Log("You lose!");
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                transform.position = Vector3.zero;
                foreach(var e in children)
                {
                    e.gameObject.SetActive(true);
                }
                coins = 0;
            }        
        }
	}
}
