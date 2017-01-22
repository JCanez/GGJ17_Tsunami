using UnityEngine;
using System.Collections;

public class OlaController : MonoBehaviour {

	public GameObject canvas;
	public GameObject playerDead;
	public float frecuencia;
	public float velocidadOla;

	private AudioSource audioSource;
	public AudioClip gameOverSound;
	public float volume;

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}
	void PlayGameOverSound()
	{
		audioSource.PlayOneShot(gameOverSound, volume);
	}

	public void OnCollisionEnter2D(Collision2D obj) {
		if (obj.gameObject.name == "Player") {
			MostrarGameOver ();
			Destroy (obj.gameObject);

		}

	}

	public void OnTriggerEnter2D(Collider2D node) {
		if (node.gameObject.name == "Player") {
			MostrarGameOver ();
			Destroy(node.gameObject);
		}
	}

	void SpawnPlayerDead()
	{
		GameObject player =  GameObject.Find("Player");
		Vector3 position = player.transform.position;
		GameObject newGameObject = Instantiate(playerDead);
		newGameObject.transform.position = position;
		OlaCubreTodo ();
	}

	void OlaCubreTodo()
	{
		EnviarOla ();
	}

	public void EnviarOla()
	{
		InvokeRepeating ("AvanzarOla", frecuencia, frecuencia);
	}

	void AvanzarOla()
	{
		if (gameObject.transform.parent.position.x <= 4.64) {
			gameObject.transform.parent.Translate (new Vector3 (velocidadOla, 0, 0) * Time.deltaTime);
		} 

	}

	public void MostrarGameOver()
	{
		canvas.SetActive (true);
		SpawnPlayerDead ();
		PlayGameOverSound ();
		//StopTime ();
	}

	void StopTime()
	{
		Time.timeScale = 0.00001f;
	}
}
