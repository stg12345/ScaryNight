using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public float Speed;
	private RaycastHit2D[] hit;
	Vector2 Direction;
	public float DistancetoGround;
	private bool Grounded = false;

	// Use this for initialization
	void Start () {
		Speed=6f;
		DistancetoGround = 0.7f;
		Direction = new Vector2(0,-1);
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*Vector2 Temp = rigidbody2D.velocity;
		Temp.x = 0;
		rigidbody2D.velocity = Temp;*/

		Debug.Log("Current Speed is " + rigidbody2D.velocity.x);
		Grounding ();
		ManipulatePhysics ();
		Debug.Log("Linear Drag : " +rigidbody2D.drag);
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
	{	ManipulatePhysics ();
		if(Grounded == true)
		{		if(Input.GetButtonDown("Jump"))
				{
				rigidbody2D.AddForce (Vector3.up * 800);
		}		}

		if(rigidbody2D.velocity.x <=4 && rigidbody2D.velocity.x >=-4)
		{
			if(Input.GetKey("right")) 
			{	rigidbody2D.AddForce(new Vector2(Speed*10,0));}
			if(Input.GetButton("left")) 
			{	rigidbody2D.AddForce(new Vector2(Speed*-10,0));}
		}
	}

	void Grounding()
	{
		hit = Physics2D.RaycastAll(transform.position, Direction, DistancetoGround);
		for(int i=0; i<hit.Length;i++)
			{
				if(hit[i].collider.gameObject.tag == "Ground")
					Grounded = true;
				else
					Grounded = false;
			}
	}

	void ManipulatePhysics()
	{
		if(Grounded == false)
			rigidbody2D.drag = 1;
		else
			rigidbody2D.drag = 10;
	}
} 
