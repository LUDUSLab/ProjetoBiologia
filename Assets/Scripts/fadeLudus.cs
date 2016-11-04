using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class fadeLudus : MonoBehaviour {

	public GameObject fadeIn;

	void Start () {
		Invoke("goFade", 4);
	}

	void goFade()
	{
		fadeIn.SetActive(true);
		Invoke("goMenu", 1.5f);
	}

	void goMenu()
	{
		SceneManager.LoadScene("Menu");
	}
		
}
