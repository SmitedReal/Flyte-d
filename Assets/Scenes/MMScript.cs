using UnityEngine.SceneManagement;
using UnityEngine;

public class MMScript : MonoBehaviour
{
	public GameObject SMenu;
	public void Join(string name)
	{
		SceneManager.LoadScene(name);
	}

	public void ShowSettings()
	{
		SMenu.SetActive(true);
	}
	public void CloseSettings()
	{
		SMenu.SetActive(false);
	}
}
