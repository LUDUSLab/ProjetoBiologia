using UnityEngine;
using System.Collections;

public class Escalada : MonoBehaviour {

    public GameObject indio;
    bool tato = false;
    private indiozinho personagem;

	// Use this for initialization
	void Start () {
        personagem = indio.GetComponent<indiozinho>();
    }
	
	// Update is called once per frame
	void Update () {

        stopTato();
	
	}

    void stopTato()
    {
        if(indio.transform.position.x >=4.5 && indio.transform.position.x <=5.5)
        {
            if(tato == false)
            {
                personagem.goOrStay = false;
                tato = true;
            }
        }
    }
}
