using UnityEngine;

public class GameController : MonoBehaviour
{
	public bool HasGameStarted { get; set; }

	// Use this for initialization
	int civilians;
	int collectibles;

	private AudioSource audioSource;
	public AudioClip coinSound;
	public AudioClip civilSound;
	public float volume;

	void Start()
	{
		HasGameStarted = false;
		civilians = 0;
		collectibles = 0;
	}

	// Update is called once per frame
	void Update()
	{

	}

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void ReloadScene()
	{
		Application.LoadLevel("Level1");
	}

	public void LoadMainMenu()
	{
		Application.LoadLevel("Intro");
	}

	public void IncreaseCollectible()
	{
		PlayCoinSound ();
		collectibles++;
	}
	public void IncreaseCivilians()
	{
		PlayCivilSound ();
		civilians++;
	}

	string getCollectibleText()
	{
		return "Collectibles: " + collectibles;
	}
	string getCivialsText()
	{
		return "Civilans: " + civilians;
	}
		

	void PlayCoinSound()
	{
		audioSource.PlayOneShot(coinSound, volume);
	}

	void PlayCivilSound()
	{
		audioSource.PlayOneShot(civilSound, volume);
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

		AdvancedTextRendering.DrawOutline(new Rect(0,40,100,100), 
			getCollectibleText(), 
			style,
			Color.black,
			Color.green,
			0.9f);

		AdvancedTextRendering.DrawOutline(new Rect(0,80,100,100), 
			getCivialsText(), 
			style,
			Color.black,
			Color.white,
			0.9f);

		Color c = GUI.backgroundColor;
		GUI.backgroundColor = Color.clear;
	}
}