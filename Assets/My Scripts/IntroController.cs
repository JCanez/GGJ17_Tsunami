using UnityEngine;
using System.Collections;

public class IntroController : MonoBehaviour {

	public GameObject Ola;
	GameObject olaSpawneada;
	public float velocidadOla;
	public float frecuencia;
	void Start()
	{
		Time.timeScale = 1;
		MostrarOla ();
	}
	public void IrALevel1()
	{
		Application.LoadLevel("Level1");
	}

	public void MostrarOla()
	{
		GameObject newGameObject = Instantiate(Ola);
		newGameObject.transform.position = new Vector3(-15.177683f,-3.79f,0);
		olaSpawneada = newGameObject;
	}

	public void EnviarOla()
	{
		InvokeRepeating ("AvanzarOla", frecuencia, frecuencia);
	}

	 void AvanzarOla()
	{
		if (olaSpawneada.transform.position.x <= 9.64) {
			olaSpawneada.transform.Translate (new Vector3 (velocidadOla, 0, 0) * Time.deltaTime);
		} else {
			IrALevel1 ();
		}

	}

}
