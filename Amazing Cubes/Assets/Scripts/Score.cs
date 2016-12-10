using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static float score = 0;
	public static float highscore = 0;

	Text text;

	void OnDestroy(){
		PlayerPrefs.SetFloat ("Highscore", highscore);
		PlayerPrefs.Save ();


	}

	void Start (){
		highscore = PlayerPrefs.GetFloat ("Highscore", 0);

	}


	void Awake (){

		text = GetComponent <Text> ();
		score = 0;
	}

	void Update (){
		if (score > highscore) {
		
			highscore = score;
			Debug.Log ("highscor is" + highscore);
		}
		text.text = "" + score; //+ "\n HighScore " + highscore;
	}
}
