using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
	[Header("You need Rigidbody2D for this to work")]
	private Rigidbody2D rb;
	public float MoveForce;
	public float JumpForce;

	public float DefMove;
	public float DefJump;

	void Start()
	{
		rb = gameObject.GetComponent<Rigidbody2D>();

		DefMove = MoveForce;
		DefJump = JumpForce;
	}
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

		if (Input.GetKeyDown(KeyCode.UpArrow))
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
	}


	public void SetSpeed(float move, float jump)
	{
		JumpForce = jump;
		MoveForce = move;
	}

	public void SetSpeed(Vector2 v)
	{
		MoveForce = v.x;
		JumpForce = v.y;
	}

	public float GetMove()
	{
		return MoveForce;
	}
	public float GetJump()
	{
		return JumpForce;
	}

	public float GetDefMove()
	{
		return DefMove;
	}
	public float GetDefJump()
	{
		return DefJump;
	}
}
