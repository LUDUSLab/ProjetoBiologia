using UnityEngine;
using System.Collections;

public class Escalada : MonoBehaviour {

    public GameObject indio;
    bool tato = false;
    private indiozinho personagem;
	public float forcinhaPraPular;

	// Use this for initialization
	void Start () {
        personagem = indio.GetComponent<indiozinho>();
    }
	
	// Update is called once per frame
	void Update () {

        stopTato();
		goEscalada();
	
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

	void goEscalada()
	{
		if(Input.GetKeyDown(KeyCode.Keypad3))
		{
			Vector2 direcaoPulo = new Vector2(0.1f,0.5f);
			direcaoPulo.Normalize();
			indio.GetComponent<Rigidbody2D>().AddForce(direcaoPulo * forcinhaPraPular);
		}
	}
}
