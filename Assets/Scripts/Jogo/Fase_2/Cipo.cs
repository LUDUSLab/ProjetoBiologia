using UnityEngine;
using System.Collections;

public class Cipo : MonoBehaviour {

    public GameObject indio, cipoVerde;
    private indiozinho personagem;
    bool visao = false, tato = false;
    public float forcinhaPraPular;

    void Start () {
        personagem = indio.GetComponent<indiozinho>();
    }
	
	void Update () {
        stopVerCipo();
        goVerCipo();
        stopPularCipo();
        goPularCipo();
	}

    void stopVerCipo()
    {
        if(indio.transform.position.x >= 16 && indio.transform.position.x <= 16.9)
        {
            if(visao == false)
            {
                personagem.goOrStay = false;
                visao = true;
            }
        }
    }

    void goVerCipo()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            cipoVerde.SetActive(true);
            personagem.goOrStay = true;
        }
    }

    void stopPularCipo()
    {
        if (indio.transform.position.x >= 23.5 && indio.transform.position.x <= 23.9)
        {
            if (tato == false)
            {
                personagem.goOrStay = false;
                tato = true;
            }
        }
    }

    void goPularCipo()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (tato == true)
            {
                tato = false;
                Vector2 direcaoPulo = new Vector2(0.1f, 0.5f);
                direcaoPulo.Normalize();
                indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
                //this.GetComponent<Cipo>().enabled = false;
                personagem.goOrStay = true;
            }
        }
    }
}
