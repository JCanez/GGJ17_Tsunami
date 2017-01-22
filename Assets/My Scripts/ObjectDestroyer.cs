using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

	public GameObject canvas;

	AudioSource audio_game;
	public AudioClip audioGameOver;

	void Start () {
		GameObject audio = GameObject.FindGameObjectWithTag ("Sound");
		audio_game = audio.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnCollisionEnter2D(Collision2D obj) {
		Destroy (obj.gameObject);
		if (obj.gameObject.tag == "Player") {
			MostrarGameOver ();
		}
	}

	public void OnTriggerEnter2D(Collider2D node) {
		Destroy(node.gameObject);
		if (node.gameObject.tag == "Player") {
			MostrarGameOver ();
		}
	}

	public void MostrarGameOver()
	{
		audio_game.Stop();
		canvas.SetActive (true);

		//StopTime ();
	}

	void StopTime()
	{
		Time.timeScale = 0.00001f;
	}
}
