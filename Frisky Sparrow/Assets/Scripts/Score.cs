using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static float score = 0;
	public static float highscore = 0;
	public static bool LearningPhase = true;

	Text text;

	void OnDestroy(){
		PlayerPrefs.SetFloat ("Highscore", highscore);
		PlayerPrefs.Save ();


	}

	void Start (){
		highscore = PlayerPrefs.GetFloat ("Highscore", 0);
		Debug.Log ("LearningPhase =" + LearningPhase);

	}


	void Awake (){

		text = GetComponent <Text> ();
		score = 0;
	}

	void Update (){
		if (score > 2 || score == 2) {
			LearningPhase = false;
		}
		if (score > highscore) {
		
			highscore = score;
			Debug.Log ("highscor is" + highscore);
		}
		text.text = "" + score; //+ "\n HighScore " + highscore;
	}
}
