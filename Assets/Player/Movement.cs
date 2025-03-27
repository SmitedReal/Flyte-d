using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

	public Rigidbody2D rb;
	public Transform Player;
	public float JumpForce;
	public float MoveForce;
	// Update is called once per frame
	void Update()
	{
		// Jump
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(new Vector2(1, JumpForce * 100));
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			rb.AddForce(new Vector2(1, JumpForce * 100));
		}

		// Move

		if (Input.GetKeyDown(KeyCode.A))
		{
			rb.AddForce(new Vector2(MoveForce * 100, 0));
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			rb.AddForce(new Vector2(-MoveForce * 100, 0));
		}

		/*
		if (Input.GetKeyDown(KeyCode.A))
		{
			Player.Translate(new Vector2(-MoveForce * 100, 0) * Time.deltaTime, Space.World);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			Player.Translate(new Vector2(MoveForce * 100, 0) * Time.deltaTime, Space.World);
		}
		*/
	}
}
