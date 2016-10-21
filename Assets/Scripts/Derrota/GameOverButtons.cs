using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {

    public string tryAgain;

	public void Menu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void TryAgain()
	{
		SceneManager.LoadScene (tryAgain);
	}

	public void MenuTo()
	{
		SceneManager.LoadScene ("Menu");
	}

}
