using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	public static float highscore = 0;
	Text text;
	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetFloat ("Highscore", 0);
	}
	void Awake (){
		text = GetComponent <Text> ();
	}
	// Update is called once per frame
	void Update () {
		text.text = " Highscore " + highscore;
	}
}
