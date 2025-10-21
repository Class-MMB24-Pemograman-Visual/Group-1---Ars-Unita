using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float speed = 20.0f;
	private float turnspeed = 45.0f;
	private float horizontalInput;
	private float forwardInput;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		
		// Move the car forward based on Vertical input
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		// Rotates te car based on Horizontal input
		transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
		
    }
}
