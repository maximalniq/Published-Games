using UnityEngine;
using System.Collections;


public class Death : MonoBehaviour {
	public GameObject RightParticle;
	public GameObject LeftParticle;
	public AdmobManager _AdmobManager;
	public int RandomAdNumber;



	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "Player") {
			DeathSound.DeathSoundActive = true;
			GameManager.LeftButtonActive = false;
			GameManager.RightButtonActive = false;
			DeathParticle.DeathParticles = true;
			HidePlayer.hideplayer = true;
			RightParticle.SetActive(false);
			LeftParticle.SetActive(false);
			StartCoroutine (StopTime ());
			StartCoroutine (ShowAd ());
			//_AdmobManager.ShowInterstitial();

		}
	}
	IEnumerator StopTime (){
		yield return new WaitForSeconds (0.4f);
		GameManager.RestartButtonActive = true;

	}
	IEnumerator ShowAd (){
		yield return new WaitForSeconds (0.6f);
		Time.timeScale = 0;
		RandomAdNumber = Random.Range (0, 3);
		Debug.Log ("random number e" + RandomAdNumber);
		if (RandomAdNumber == 0) {
			_AdmobManager.ShowInterstitial ();
		}
	}

}