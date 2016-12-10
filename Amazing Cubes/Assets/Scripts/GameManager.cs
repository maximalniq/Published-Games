using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static bool LeftButtonActive = true;
	public static bool RightButtonActive = true;
	public static bool StartButtonActive = true;
	public static bool HighScoreButtonActive = true;
	public static bool RestartButtonActive = false;
	public GameObject ScoreText;
	public GameObject HighScoreButton;
	public GameObject StartButton;
	public GameObject LeftButton;
	public GameObject RightButton;
	public GameObject RestartButton;

	public void OnRestartButtonClicked (){
		Application.LoadLevel (Application.loadedLevel);
	}

	public void OnButtonClicked (){
		Time.timeScale = 1;
		StartButtonActive = false;
		HighScoreButtonActive = false;
		ScoreText.SetActive (true);
	}

	void Start(){
		RestartButtonActive = false;
		Debug.Log (ChangeColor.RandomColour);
		ChangeColor.RandomColour = Random.Range (0, 5);
		ScoreText.SetActive (false);
		ChangeColor.ChangeColourBool = true;
		Time.timeScale = 0;
		HighScoreButtonActive = true;
		StartButtonActive = true;
		LeftButtonActive = true;
		RightButtonActive = true;
	}

	void Update(){
		if (RestartButtonActive == true) {
			RestartButton.SetActive(true);
		}
		if (HighScoreButtonActive == false) {
			HighScoreButton.SetActive(false);
		}
		if (HighScoreButtonActive == true) {
			HighScoreButton.SetActive(true);
		}

		if (StartButtonActive == true){
			StartButton.SetActive (true);
		}

		if (StartButtonActive == false){
			StartButton.SetActive (false);
		}

		if (LeftButtonActive == true) {
			LeftButton.SetActive (true);
		}

		if (LeftButtonActive == false) {
			LeftButton.SetActive (false);
		}

		if (RightButtonActive == true) {
			RightButton.SetActive (true);
		}
		
		if (RightButtonActive == false) {
			RightButton.SetActive (false);
		}
	}
}
