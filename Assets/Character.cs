using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public int Speed;
	// Use this for initialization
	void Start () {
		Speed =10;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("right")) 
			rigidbody2D.AddForce (Vector3.right * 2);
		if(Input.GetButton("left")) 
			rigidbody2D.AddForce (Vector3.left * 2);
	}



	void OnCollisionStay2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Crate")
		{ if(Input.GetButton("Action"))
			{

			}
		}
	}

	void FixedUpdate () 
	{
		if(Input.GetButtonDown("Jump"))
		rigidbody2D.AddForce (Vector3.up * 100);
	}
} 
