using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CHLOG : MonoBehaviour
{
	public Slider s;
	public TMP_Text t;
	public string name = "MM";

	void Update()
	{
		t.fontSize = s.value;

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(name);
		}
	}
}
