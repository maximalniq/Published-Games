using UnityEngine;
using System.Collections;

public class RotateTriggers : MonoBehaviour {
	public  float RotationSpeed = 1.5f;
	public  bool TapNow = false;
	public float StartingPitch = 1f;
	AudioSource audioto;
	public GameObject TapNowText;
	public bool Playing = false;
	public GameObject Highscore;
	public GameObject BestText;
	public GameObject ScoreText;
	public bool PlayerIsDead = false;
	public GameObject TapButton;
	public static int CounterForAds = 0;
	public AdmobManager _AdmobManager;

	private void IncreaseSpeed () {
			RotationSpeed += 0.1f;
		StartingPitch += 0.01f;
	}
	void Awake() {
		Application.targetFrameRate = 60;
	}
	
	void Start() {
		Debug.Log("counter for ads is" + CounterForAds);
		audioto = GetComponent<AudioSource> ();
		audioto.pitch = StartingPitch;
	}

	void Update () {
		transform.Rotate (Vector3.back * RotationSpeed);
		audioto.pitch = StartingPitch;
		TapNowCheck ();
		HideTextWhenPlaying ();
		PlayerDeath ();

	}

	void PlayerDeath (){
		if (PlayerIsDead == true) {
			TapButton.SetActive (false);
			RotationSpeed = 0f;
		}
	}

	void HideTextWhenPlaying (){
		if (Playing == true) {
			Highscore.SetActive (false);
			BestText.SetActive (false);
			ScoreText.SetActive (true);
		} else {
			Highscore.SetActive (true);
			BestText.SetActive (true);
			ScoreText.SetActive (false);
		}
	}

	void TapNowCheck (){
		if (TapNow == true && Playing == false) {
			TapNowText.SetActive (true);
		} 
		else {TapNowText.SetActive (false);
		}
	}
	
	void OnTriggerEnter2D (Collider2D col){
		TapNow = true;
	}

	void OnTriggerExit2D(Collider2D col){
		TapNow = false;
	}

	public void OnPointerDown (){
		if (TapNow == true) {
			IncreaseSpeed ();
			audioto.Play ();
			Playing = true;
			Score.score += 1f;
		} else {
			CounterForAds += 1;
			if(CounterForAds > 2){
				CounterForAds = 0;
				StartCoroutine ("ShowAd");
				Debug.Log("show ad");
			}
			PlayerIsDead = true;
			Handheld.Vibrate ();
			StartCoroutine ("RestartLevel");
		}
	}
	IEnumerator RestartLevel (){
		yield return new WaitForSeconds (1f);
		Application.LoadLevel (Application.loadedLevel);
	}
	IEnumerator ShowAd (){
		yield return new WaitForSeconds (0.8f);
		_AdmobManager.ShowInterstitial();
	}
}
