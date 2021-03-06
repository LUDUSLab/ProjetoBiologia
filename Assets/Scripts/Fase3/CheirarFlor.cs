﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CheirarFlor : MonoBehaviour {

	public GameObject  indio, balaoDuvida, 	barraTempoObject, flores, fadeIn;
	private indiozinho personagem;
	bool nariz = false, parar = false;
    public string cheirar = "event:/Cheirar";

	//public float tempoBarrinha;
	//private float tempoInicial;
	// Use this for initialization
	void Start () {
		personagem = indio.GetComponent<indiozinho>();
	}
	
	// Update is called once per frame
	void Update () {
		stopCheirar();
		goCheirar();
	}
	void stopCheirar()
	{
		if(indio.transform.position.x >=96.1 && indio.transform.position.x <= 96.4)
		{
			if(nariz == false)
			{
				barraTempoObject.SetActive (true);
				balaoDuvida.SetActive (true);
				personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("parar", true);
				indio.GetComponent<Animator>().SetBool("cheirar", true);
                FMODUnity.RuntimeManager.PlayOneShot(cheirar);
				nariz = true;
			}

		}
	}

	void goCheirar()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
		{
			if(indio.transform.position.x >=96.1 && indio.transform.position.x <= 96.4)
			{
				balaoDuvida.SetActive (false);
				barraTempoObject.SetActive(false);
				//personagem.goOrStay = true;
				//indio.GetComponent<Animator>().SetBool("cheirar", false);
				indio.GetComponent<Animator>().SetBool("pegar", true);
				indio.GetComponent<Animator>().SetBool("parar", false);
				GetComponent<Score>().Addscore();
				//KD ELE CHEIRANDO
				Invoke("SumirFlor", 2);
			}
		}
		else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Keypad4))
		{
			if (indio.transform.position.x >= 94.1 && indio.transform.position.x <= 94.4)
			{
				
				fadeIn.SetActive(true);
				Invoke("goGameOver", 1.5f);
			}
		}
	}

	void SumirFlor(){
		flores.SetActive(false);
		indio.GetComponent<Animator>().SetBool("pegar", false);
		indio.GetComponent<Animator>().SetBool("parar", false);
		personagem.goOrStay = true;
	}

	void goGameOver()
	{
		SceneManager.LoadScene("gameOver");
	}
}
