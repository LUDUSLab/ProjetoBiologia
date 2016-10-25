using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Escalada : MonoBehaviour {

    public GameObject indio, barraTempoObject, balaoDuvida;
    bool tato = false;
    private indiozinho personagem;
	public float forcinhaPraPular;
    public float tempoBarrinha;
    private float tempoInicial;

	// Use this for initialization
	void Start () {
        personagem = indio.GetComponent<indiozinho>();
    }
	
	// Update is called once per frame
	void Update () {
        stopTato();
		goEscalada();
        if(Time.time - tempoInicial > tempoBarrinha && barraTempoObject.active)
        {
            SceneManager.LoadScene("gameOver");
        }
	}

    void stopTato()
    {
        if(indio.transform.position.x >=4.3 && indio.transform.position.x <=4.7)
        {
            if(tato == false)
            {
				balaoDuvida.SetActive (true);
                personagem.goOrStay = false;
                indio.GetComponent<Animator>().SetBool("parar", true);
                barraTempoObject.SetActive(true);
                tempoInicial = Time.time;
                tato = true;
            }
        }
    }

	void goEscalada()
	{
		if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Q))
        {
			balaoDuvida.SetActive (false);
            Vector2 direcaoPulo = new Vector2(0.1f, 0.7f);
            direcaoPulo.Normalize();
            indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
            this.GetComponent<Escalada>().enabled = false;
			indio.GetComponent<Animator>().SetBool("pulando", true);
			//personagem.goOrStay = true;
			Invoke("VoltaraAndar", 1.2f);
            barraTempoObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            if (indio.transform.position.x >= 4.3 && indio.transform.position.x <= 4.7)
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
