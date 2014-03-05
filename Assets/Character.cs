using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public float Speed;
	public KeyCode Left;
	public KeyCode Right;

	// Use this for initialization
	void Start () {
		Speed=3;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*Vector2 Temp = rigidbody2D.velocity;
		Temp.x = 0;
		rigidbody2D.velocity = Temp;*/
		if(rigidbody2D.velocity.x <=4)
		{
			if(Input.GetKey("right")) 
			{	Vector2 tmp;
				tmp.x = Speed;
				tmp.y = 0;
				rigidbody2D.AddForce(new Vector2(Speed,0));}
			if(Input.GetButton("left")) 
			{	Vector2 tmp;
				tmp.x = Speed*-1;
				tmp.y = 0;
				rigidbody2D.AddForce(new Vector2(Speed*-1,0));}
		}
		Debug.Log(rigidbody2D.velocity.x);
			
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
		rigidbody2D.AddForce (Vector3.up * 400);

		if(rigidbody2D.velocity.x <=4)
		{
			if(Input.GetKey("right")) 
			{	Vector2 tmp;
				tmp.x = Speed;
				tmp.y = 0;
				rigidbody2D.AddForce(new Vector2(Speed,0));}
			if(Input.GetButton("left")) 
			{	Vector2 tmp;
				tmp.x = Speed*-1;
				tmp.y = 0;
				rigidbody2D.AddForce(new Vector2(Speed*-1,0));}
		}
	}
} 
