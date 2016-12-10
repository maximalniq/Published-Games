using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static float score = 0;
	public static float highscore = 0;

	Text text;

	void OnDestroy(){
		PlayerPrefs.SetFloat ("HighScore", highscore);
		PlayerPrefs.Save ();

	}

	void Start (){
		Time.timeScale = 0;
		highscore = PlayerPrefs.GetFloat ("HighScore", 0);

	}


	void Awake (){

		text = GetComponent <Text> ();
		score = 0;
	}

	void Update (){
		if (score > highscore) {
			Debug.Log ("dadum");
			highscore = score;
		}
		text.text = "" + score; //+ "\n HighScore " + highscore;
	}
}
