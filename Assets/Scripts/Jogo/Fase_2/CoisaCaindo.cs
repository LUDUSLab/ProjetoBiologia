using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CoisaCaindo : MonoBehaviour {

	public GameObject objetoCaindo, indio;
	bool audicao = false;
	private indiozinho personagem;

	void Start () {
		personagem = indio.GetComponent<indiozinho>();
	}


	void Update () {
		goCair();
		stopAudicao();
		goAudicao();
	}

	void goCair()
	{
		if(indio.transform.position.x >= 32 && indio.transform.position.x <= 32.3)
		{
			objetoCaindo.SetActive(true);
		}
	}

	void stopAudicao()
	{
		if(indio.transform.position.x >= 35 && indio.transform.position.x <= 35.1)
		{
			if(audicao == false)
			{
				personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("parar", true);
				audicao = true;
			}
		}
	}

	void goAudicao()
	{
		if(Input.GetKeyDown(KeyCode.Keypad4))
		{
			if(audicao == true)
			{
				audicao = false;
				objetoCaindo.SetActive(false);
				personagem.goOrStay = true;
				indio.GetComponent<Animator>().SetBool("parar", false);
			}
		}
		else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad5))
		{
			if (indio.transform.position.x >= 35 && indio.transform.position.x <= 35.1)
			{
				SceneManager.LoadScene("gameOver");
			}
		}
	}


}
