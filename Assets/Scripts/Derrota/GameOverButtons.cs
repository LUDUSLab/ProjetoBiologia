using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {

	public void Menu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void TryAgain()
	{
		SceneManager.LoadScene ("Fase1");
	}

	public void MenuTo()
	{
		SceneManager.LoadScene ("Menu");
	}

}
