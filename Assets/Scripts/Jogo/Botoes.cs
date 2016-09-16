using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour {

    public GameObject balAud, balTato, balVisao, balPaladar, balOlfato, indio, babanana, pedrinha, moita, flor;
    bool audi=false, tato=false, visa=false, pala=false, olfa=false;
    private indiozinho personagem;


	void Start () {
        personagem = indio.GetComponent<indiozinho>();
	}
	
	void Update () {
        stopA();
        goA();
        stopB();
        goB();
        stopC();
        goC();
        bananaCaindo();
        stopD();
        goD();
        stopE();
        goE();
     
        
	}

    void stopA ()
    {
        if (indio.transform.position.x >= -2.72 && indio.transform.position.x <= -1)
        {
            if (audi == false)
            {
                personagem.goOrStay = false;
                audi = true;
                balAud.SetActive(true);
            }
        }
    }

    void goA()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if(balAud.active == true)
            {
                balAud.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopB()
    {
        if (indio.transform.position.x >= 13 && indio.transform.position.x <= 14)
        {
            if (tato == false)
            {
                personagem.goOrStay = false;
                tato = true;
                balTato.SetActive(true);
            }
        }
    }

    void goB()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (balTato.active == true)
            {
                balTato.SetActive(false);
                pedrinha.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopC()
    {
        if (indio.transform.position.x >= 31.9 && indio.transform.position.x <= 32.9)
        {
            if (visa == false)
            {
                personagem.goOrStay = false;
                visa = true;
                balVisao.SetActive(true);
            }
        }
    }

    void goC()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (balVisao.active == true)
            {
                moita.SetActive(false);
                balVisao.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopD()
    {
        if (indio.transform.position.x >= 42.58 && indio.transform.position.x <= 43.58)
        {
            if (pala == false)
            {
                personagem.goOrStay = false;
                pala = true;
                balPaladar.SetActive(true);
            }
        }
    }

    void goD()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            if (balPaladar.active == true)
            {
                babanana.SetActive(false);
                balPaladar.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void stopE()
    {
        if (indio.transform.position.x >= 62.45 && indio.transform.position.x <= 63.45)
        {
            if (olfa == false)
            {
                personagem.goOrStay = false;
                olfa = true;
                balOlfato.SetActive(true);
            }
        }
    }

    void goE()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            if (balOlfato.active == true)
            {
                flor.SetActive(false);
                balOlfato.SetActive(false);
                personagem.goOrStay = true;
            }
        }
    }

    void bananaCaindo()
    {
        if(indio.transform.position.x >= 37.77 && indio.transform.position.x <= 38.77)
        {
            babanana.SetActive(true);
        }
    }
}
