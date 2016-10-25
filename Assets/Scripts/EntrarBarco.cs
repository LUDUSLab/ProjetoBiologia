using UnityEngine;
using System.Collections;

public class EntrarBarco : MonoBehaviour {

	public GameObject indio, canoa;
	private indiozinho personagem;
	bool barco = false;
	public float forcinhaPraPular;

	// Use this for initialization
	void Start () {
		personagem = indio.GetComponent<indiozinho>();
	}
	
	// Update is called once per frame
	void Update () {

		stopTato();
		//goEscalada();
	
	}

	void stopTato()
	{
		if(indio.transform.position.x >=85.1&& indio.transform.position.x <=85.8)
		{
			if(barco == false)
			{
				personagem.goOrStay = false;
				indio.GetComponent<Animator>().SetBool("parar", true);
				barco = true;
				Invoke("pularNoBarco", 2);

			}
		}
	}

	void pularNoBarco (){
		Vector2 direcaoPulo = new Vector2(0.5f, 0.7f);
		direcaoPulo.Normalize();
		indio.GetComponent<Animator>().SetBool("pulando", true);
		indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
		Invoke("ficarNoBarco", 0.6f);
	}

	void ficarNoBarco(){
		indio.transform.SetParent(canoa.transform);
		indio.GetComponent<Animator>().SetBool("pulando", false);
		indio.GetComponent<Animator>().SetBool("parar", true);
		Invoke("Navegar", 2);
	}

	void Navegar(){
		canoa.GetComponent<Animator>().SetBool("navegar", true);
	}

	/*void goEscalada()
	{
		if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Q))
		{
			
			Vector2 direcaoPulo = new Vector2(0.1f, 0.7f);
			direcaoPulo.Normalize();
			indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
			this.GetComponent<Escalada>().enabled = false;
			indio.GetComponent<Animator>().SetBool("pulando", true);
			//personagem.goOrStay = true;
			Invoke("VoltaraAndar", 0.6f);

		}

	}*/
}
