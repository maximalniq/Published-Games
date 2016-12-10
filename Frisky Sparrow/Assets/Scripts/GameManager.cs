using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject StartButton;
	public GameObject HighScoreText;
	public GameObject HighScore;
	public GameObject StartText;
	public AdmobManager _AdmobManager;
	
	void Start () {
		Time.timeScale = 0;
		Death.PlayerIsDead = false;
	}

	public void OnStartButtonClicked (){
		Time.timeScale = 1;
		StartButton.SetActive (false);
		HighScoreText.SetActive (false);
		HighScore.SetActive (false);
		StartText.SetActive (false);

	}
	public void OnRestartButtonClicked (){
		Application.LoadLevel (Application.loadedLevel);

	}

}
