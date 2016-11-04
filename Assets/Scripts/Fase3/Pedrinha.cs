﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pedrinha : MonoBehaviour {

	public GameObject indio, balaoDuvida, feedBackVisao, PedraConcreta, barraTempo;
	bool tato = false;
	bool visao = false;
	private indiozinho personagem;
	public float forcinhaPraPular;

	// Use this for initialization
	void Start () {
		personagem = indio.GetComponent<indiozinho>();
	}

	// Update is called once per frame
	void Update () {
		stopOlhar();
		goOlhar();
		stopTato();
		GoTato();
	}

	void stopOlhar()
	{
		if(indio.transform.position.x >=73.7 && indio.transform.position.x <=73.9)
		{
			if(visao == false)
			{
				barraTempo.SetActive(true);
				balaoDuvida.SetActive (true);
				feedBackVisao.SetActive (true);
				personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("pulando", false);
				indio.GetComponent<Animator>().SetBool("parar", true);
				visao = true;
			}
		}
	}

	void goOlhar()
	{
		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			if (indio.transform.position.x >= 73.7 && indio.transform.position.x <= 73.9)
			{
				barraTempo.SetActive(false);
				indio.GetComponent<Animator>().SetBool("parar", false);
				balaoDuvida.SetActive(false);
				feedBackVisao.SetActive (false);
				PedraConcreta.SetActive(true);
				personagem.goOrStay = true;
				GetComponent<Score>().Addscore();
			}
		}
		else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
		{
			if (indio.transform.position.x >= 73.7 && indio.transform.position.x <= 73.9)
			{
				SceneManager.LoadScene("gameOver");
			}
		}

	}
	void stopTato()
	{
		if(indio.transform.position.x >=77.6 && indio.transform.position.x <=77.8)
		{
			if(tato == false)
			{
				barraTempo.SetActive(true);				
				balaoDuvida.SetActive (true);
				personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("parar", true);
				tato = true;
			}
		}
	}

	void GoTato(){

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			if (indio.transform.position.x >= 77.6 && indio.transform.position.x <= 77.8)
			{
				barraTempo.SetActive(false);
				balaoDuvida.SetActive(false);
				Vector2 direcaoPulo = new Vector2(0.2f, 0.8f);
				direcaoPulo.Normalize();
				indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
				//this.GetComponent<Escalada>().enabled = false;
				indio.GetComponent<Animator>().SetBool("pulando", true);
				//personagem.goOrStay = true;
				Invoke("VoltaraAndar", 0.6f);
				GetComponent<Score>().Addscore();
			}
		}
		else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha4))
		{
			if (indio.transform.position.x >= 77.6 && indio.transform.position.x <= 77.8)
			{
				SceneManager.LoadScene("gameOver");
			}
		}
	}

	void VoltaraAndar(){
		personagem.goOrStay = true;
		indio.GetComponent<Animator>().SetBool("parar", false);
		indio.GetComponent<Animator>().SetBool("pulando", false);
	}
}

