using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	public static float highscore = 0;
	Text text;
	// Use this for initialization
	void Start () {
		AudioListener.volume = 0f;
		highscore = PlayerPrefs.GetFloat ("HighScore", 0);
	}
	void Awake (){
		text = GetComponent <Text> ();
	}
	// Update is called once per frame
	void Update () {
		text.text = " HighScore " + highscore;
	}
}
