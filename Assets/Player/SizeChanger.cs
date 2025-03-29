using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class SizeChanger : MonoBehaviour
{
	[Header("You need Collider2D for this to work")]
	public LayerMask collisionLayer;

	public Vector3 v;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject g = collision.gameObject;
		// Check if the collided object is on the selected layer
		if (collisionLayer == (collisionLayer | (1 << g.layer)))
		{
			SChange(g);
		}
	}

	public void SChange(GameObject g)
	{
		g.GetComponent<Transform>().localScale = v;
	}
}
