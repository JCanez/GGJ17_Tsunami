using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civil : MonoBehaviour {

AudioSource audio;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("a");
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Hola");
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		}
	}
}
