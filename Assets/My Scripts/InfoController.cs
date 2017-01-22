using UnityEngine;
using System.Collections;

public class InfoController : MonoBehaviour {

	string nombreUriel="Uriel Carrillo Moreno";
	string sitioUriel="ranacalva.com";
	string nombreRafa="Rafael Montoya Boneo";
	string sitioRafa="rafeo.blogspot.com";
	string nombreJuan="Juan Pablo Cañez";
	string sitioJuan="";
	string nombreRafita="Ráffukc Zeta";
	string sitioRafita="fb.com/zmultimediaOficial";
	public void IrAIntro()
	{
		Application.LoadLevel("Intro");
	}

	void OnGUI()
	{

		GUIStyle style = new GUIStyle();
		style.normal.textColor = Color.red;
		style.fontSize = 40;
		style.fontStyle = FontStyle.Bold;

		//GUI.skin.font = pixelFont;
		style.normal.textColor = Color.green;
		//GUI.Label(new Rect(20, 20, 100, 100), scoreText, style);

		float margenIzquierdo = Screen.width / 4;
		float margenCentro = Screen.height / 4;
		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro,100,100), 
			"Credits", 
			style,
			Color.black,
			Color.yellow,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+40,100,100), 
			nombreUriel, 
			style,
			Color.black,
			Color.green,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+80,100,100), 
			sitioUriel, 
			style,
			Color.black,
			Color.green,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+120,100,100), 
			nombreRafa, 
			style,
			Color.black,
			Color.blue,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+160,100,100), 
			sitioRafa, 
			style,
			Color.black,
			Color.blue,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+200,100,100), 
			nombreJuan, 
			style,
			Color.black,
			Color.red,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+240,100,100), 
			"Music:", 
			style,
			Color.black,
			Color.magenta,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+280,100,100), 
			nombreRafita, 
			style,
			Color.black,
			Color.magenta,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(margenIzquierdo,margenCentro+320,100,100), 
			sitioRafita, 
			style,
			Color.black,
			Color.magenta,
			0.9f);

		Color c = GUI.backgroundColor;
		GUI.backgroundColor = Color.clear;
	}

}
