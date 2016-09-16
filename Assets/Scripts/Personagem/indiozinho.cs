using UnityEngine;
using System.Collections;

public class indiozinho : MonoBehaviour { 

	public int velo;

	void Update () {

	}

	void Andando()
	{
        
        transform.position(Vector2.right * velo * Time.deltaTime);

	}

}