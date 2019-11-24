using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float rotateSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//(0.2,0.2,0.2)
		transform.Rotate(Vector3.forward * rotateSpeed);
    }
}
