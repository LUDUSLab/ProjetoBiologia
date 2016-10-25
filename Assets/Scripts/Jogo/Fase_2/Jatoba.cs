using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Jatoba : MonoBehaviour {

	public GameObject jatobazinho, indio, balaoDuvida, 	barraTempoObject;
    private indiozinho personagem;
    bool paladar = false, nariz = false;
	public float tempoBarrinha;
	private float tempoInicial;

    void Start () {
        personagem = indio.GetComponent<indiozinho>();
	}
	
	void Update () {
        jatobaCaindo();
		stopCheirar();
		goCheirar();
        stopJatoba();
        goJatoba();
    }

    void jatobaCaindo()
    {
        if (indio.transform.position.x >= 57.5 && indio.transform.position.x <= 57.9)
        {
            jatobazinho.SetActive(true);
        }
    }

	void stopCheirar()
	{
		if(indio.transform.position.x >=63 && indio.transform.position.x <= 63.1)
		{
			if(nariz == false)
			{
				personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("parar", true);
				nariz = true;
			}
			
		}
	}

	void goCheirar()
	{
		if(Input.GetKeyDown(KeyCode.Keypad1))
		{
			if(nariz == true)
			{
				nariz = false;
				barraTempoObject.SetActive(false);
				personagem.goOrStay = true;
				indio.GetComponent<Animator>().SetBool("parar", false);
				//KD ELE CHEIRANDO
				//Invoke("VoltaraAndar", 4);
			}
		}
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Keypad5))
		{
			if (indio.transform.position.x >= 63 && indio.transform.position.x <= 63.1)
			{
				Debug.Log("Batata Doce");
				SceneManager.LoadScene("gameOver");
			}
		}
	}

    void stopJatoba()
    {
        if(indio.transform.position.x >= 65 && indio.transform.position.x <= 65.1)
        {
            if(paladar == false)
            {
				balaoDuvida.SetActive (true);
                personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("parar", true);
                paladar = true;
            }
        }

    }
    
    void goJatoba()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if(paladar == true)
            {
				balaoDuvida.SetActive (false);
                paladar = false;
                this.GetComponent<Jatoba>().enabled = false;
				indio.GetComponent<Animator>().SetBool("comer", true);
				jatobazinho.SetActive(false);
				Invoke("VoltaraAndar", 4);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            if (indio.transform.position.x >= 65 && indio.transform.position.x <= 65.1)
            {
                SceneManager.LoadScene("gameOver");
            }
        }
    }

	void VoltaraAndar(){
		personagem.goOrStay = true;
		indio.GetComponent<Animator>().SetBool("parar", false);
	}
}
