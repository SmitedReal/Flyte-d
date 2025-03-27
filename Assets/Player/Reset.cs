using UnityEngine;

public class Reset : MonoBehaviour
{
	public LayerMask collisionLayer; // Layer to detect collisions with
	public Vector2 Place = new Vector2(0, 0);

	// Update is called once per frame
	void Update()
	{
		// Check if the "R" key is pressed
		if (Input.GetKeyDown(KeyCode.R))
		{
			ResetPlayer();
		}
	}

	// This function is called when the player collides with another object
	private void OnCollisionEnter2D(Collision2D collision)
	{
		// Check if the collided object is on the selected layer
		if (collisionLayer == (collisionLayer | (1 << collision.gameObject.layer)))
		{
			ResetPlayer();
		}
	}

	// Function to reset the player's position and rotation
	private void ResetPlayer()
	{
			// Reset position to (x and y)
			transform.position = Place;
		// Reset rotation to default (no rotation)
		transform.rotation = Quaternion.identity;
	}
}