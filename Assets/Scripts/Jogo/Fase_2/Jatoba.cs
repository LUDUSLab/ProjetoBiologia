using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Jatoba : MonoBehaviour {

    public GameObject jatobazinho, indio;
    private indiozinho personagem;
    bool paladar = false;

    void Start () {
        personagem = indio.GetComponent<indiozinho>();
	}
	
	void Update () {
        jatobaCaindo();
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

    void stopJatoba()
    {
        if(indio.transform.position.x >= 65 && indio.transform.position.x <= 65.1)
        {
            if(paladar == false)
            {
                personagem.goOrStay = false;
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
                jatobazinho.SetActive(false);
                personagem.goOrStay = true;
                paladar = false;
                this.GetComponent<Jatoba>().enabled = false;

            }
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            if (indio.transform.position.x >= 65 && indio.transform.position.x <= 65.5)
            {
                SceneManager.LoadScene("gameOver");
            }
        }
    }
}
