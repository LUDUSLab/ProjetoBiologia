using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour {
	
	//public string GameOverScene;

	void OnBecameInvisible()
	{
		Debug.Log ("entrou");
		SceneManager.LoadScene("GameOver");
	}
}
