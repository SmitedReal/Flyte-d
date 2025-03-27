using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DebugCode : MonoBehaviour
{
	public TMP_InputField t;
	public Button b;
	


	public void check()
	{
		string inputText = t.text;
		SceneManager.LoadScene(inputText);
	}
}
