using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwrardForce = 2000f;
	public float sidewayForce = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () { // when dealing with physics, use fixedupdate
		int maxSpeed = 10;
		bool moveLeft;
		bool moveRight;

		//keep speed relatively constant instead of keep increasing after max speed
		if (rb.velocity.magnitude > maxSpeed) { 
			rb.velocity = rb.velocity.normalized * maxSpeed; 
		}
		else { 
			rb.AddForce(0, 0, forwrardForce * Time.deltaTime); // multiply by time.delta time to help fix difference in framerate updates
		} 
		
		//movement that fixes issues with movement not being detected due to low framerate
		if (Input.GetKey("d")) {
			moveRight = true;
		} else { moveRight = false; }

		if (Input.GetKey("a")) {
			moveLeft = true;		
		} else { moveLeft = false; }

		if (moveRight == true) { rb.AddForce(sidewayForce * Time.deltaTime, 0, 0); }
		if (moveLeft == true) { rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0); }

	}
		
}
