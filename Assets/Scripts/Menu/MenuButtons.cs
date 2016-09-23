using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {



    public void Play()
    {
        SceneManager.LoadScene("Fase1");
    }

	public void Info()
	{
		SceneManager.LoadScene ("Informations");
	}

}
