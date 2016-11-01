using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour {

    public GameObject balAud, balTato, balVisao, balPaladar, balOlfato, indio, pedrinha, moita, flor;
    bool audi=false, tato=false, visa=false, pala=false, olfa=false;
    private indiozinho personagem;
    public float forcinhaPraPular;



    void Start () {
        personagem = indio.GetComponent<indiozinho>();
	}
	
	void Update () {
        stopPassaro();
        goAudicao();
        stopPedra();
        goTato();
        stopBuraco();
        goVisao();
        stopUxi();
        goNariz();
        stopJatoba();
        goComer();
        
	}

    void stopPassaro ()
    {
        if (indio.transform.position.x >= 6.9 && indio.transform.position.x <= 7.2)
        {
            if (audi == false)
            {
                personagem.goOrStay = false;
                audi = true;
                balAud.SetActive(true);
            }
        }
    }

    void goAudicao()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            if(balAud.active == true)
            {
                balAud.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopPedra()
    {
        if (indio.transform.position.x >= 31.3 && indio.transform.position.x <= 31.5)
        {
            if (tato == false)
            {
                personagem.goOrStay = false;
                tato = true;
                balTato.SetActive(true);
            }
        }
    }

    void goTato()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (tato == true)
            {
                pedrinha.SetActive(false);
                balTato.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopBuraco()
    {
        if (indio.transform.position.x >= 51.6 && indio.transform.position.x <= 51.9)
        {
            if (visa == false)
            {
                personagem.goOrStay = false;
                visa = true;
                balVisao.SetActive(true);
            }
        }
    }

    void goVisao()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            if (balVisao.active == true)
            {
                balVisao.SetActive(false);
                Vector2 direcaoPulo = new Vector2(0.8f, 0.9f);
                direcaoPulo.Normalize();
                indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
                personagem.goOrStay = true;
            }
        }
    }

    void stopUxi()
    {
        if (indio.transform.position.x >= 68.8 && indio.transform.position.x <= 69)
        {
            if (pala == false)
            {
                personagem.goOrStay = false;
                pala = true;
                balPaladar.SetActive(true);
            }
        }
    }

    void goNariz()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (balPaladar.active == true)
            {
                balPaladar.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopJatoba()
    {
        if (indio.transform.position.x >= 107.7 && indio.transform.position.x <= 107.9)
        {
            if (olfa == false)
            {
                personagem.goOrStay = false;
                olfa = true;
                balOlfato.SetActive(true);
            }
        }
    }

    void goComer()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (balOlfato.active == true)
            {
                flor.SetActive(false);
                balOlfato.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }
}
