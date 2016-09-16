using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour { 

	public float velo;

	void Update () {
        Andando();
	}

	void Andando()
	{
        transform.Translate(Vector2.right * velo * Time.deltaTime);
    }
}