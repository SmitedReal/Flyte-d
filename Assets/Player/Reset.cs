using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Movement))]
public class Reset : MonoBehaviour
{
	[Header("You need Collider2D for this to work")]
	[Header("You need Movement for this to work")]
	public LayerMask collisionLayer;
	public Vector2 Place = new Vector2(0, 0);
	private Vector2 ResetSize = new Vector2(1,1);
	public Transform GOPlace;
	private bool b;

	void Start()
	{
		if (GOPlace == null)
		{
			b = false;
		}
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			ResetPlayer();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collisionLayer == (collisionLayer | (1 << collision.gameObject.layer)))
		{
			ResetPlayer();
		}
	}

	private void ResetPlayer()
	{
		if (b)
		{
			transform.position = GOPlace.position;
		}
		transform.position = Place;
		transform.rotation = Quaternion.identity;
		//ResetSS();
	}

	private void ResetSS()
	{
		Movement m = gameObject.GetComponent<Movement>();
		float sp = m.GetDefMove();
		float ju = m.GetDefJump();

		transform.localScale = ResetSize;

		m.SetSpeed(sp, ju);
	}
}