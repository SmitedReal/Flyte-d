using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
public class SceneJoin : MonoBehaviour
{
	[Header("You need to have BoxCollider2D for this to work.")]
	public string Joined;


	private void OnCollisionEnter2D(Collision2D collision)
	{
		SceneManager.LoadScene(Joined);
	}
}
