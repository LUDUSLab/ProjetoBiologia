using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    public GameObject persona;

	void Start () {
	
	}
	
	void Update () {
        yay();
	}

    void yay()
    {
        if(persona.transform.position.x >=70 && persona.transform.position.x <= 71)
        {
            SceneManager.LoadScene("fim");
        }
    }
}
