using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Canoa : MonoBehaviour {

	public float velo;
	private indiozinho personagem;
	public bool goOrStay = true;
	public GameObject canoa, indio, balaoDuvida;
	bool tato = false;

	void Start(){
		personagem = indio.GetComponent<indiozinho>();
		personagem.goOrStay = false;
	}

	void Update () {
		Andando();
		stopRemo();
		goRemar();
	}

	void Andando()
	{
		if (goOrStay)
		{
			transform.Translate(Vector2.right * velo * Time.deltaTime);
			indio.GetComponent<Animator> ().SetBool ("parar", true);
			indio.GetComponent<Animator> ().SetBool ("remar", true);
			//Debug.Log("andando");
		}
	}

	void stopRemo(){
		if(indio.transform.position.x >=27.5 && indio.transform.position.x <=27.9)
		{
			if(tato == false)
			{
				balaoDuvida.SetActive (true);
				goOrStay = false;
				indio.GetComponent<Animator>().SetBool("remando", false);
				tato = true;
			}
		}

	}

	void goRemar()
	{
		if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Q))
		{
			if (indio.transform.position.x >= 27.5 && indio.transform.position.x <= 27.9)
			{
				balaoDuvida.SetActive(false);
				goOrStay = true;
				GetComponent<Score>().Addscore();
			}
		}
		else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Keypad5))
		{
			if (indio.transform.position.x >= 27.5 && indio.transform.position.x <= 27.9)
			{
				SceneManager.LoadScene("gameOver");
			}
		}

	}
}