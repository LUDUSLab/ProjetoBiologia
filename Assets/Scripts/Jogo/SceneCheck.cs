using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneCheck : MonoBehaviour {

	void Start () {
        Check.ultimaFase = SceneManager.GetActiveScene().name;
	}
	
}
