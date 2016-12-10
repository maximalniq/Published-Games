using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	public GameObject DeathParticle;
	public GameObject PlayerParticle;
	public GameObject JumpButton;
	public GameObject Destroyer;
	public GameObject SpawnCollider;
	public GameObject DeathSound;
	public GameObject RestartButton;
	public AdmobManager _AdmobManager;
	private int RandomNumber;
	public static bool PlayerIsDead = false;


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Obsticle") {
			StartCoroutine (RestartLevel());
			GetComponent<Renderer> ().enabled = false;
			DeathParticle.SetActive (true);
			PlayerParticle.SetActive (false);
			JumpButton.SetActive (false);
			Destroyer.SetActive (false);
			SpawnCollider.SetActive(false);
			PlayerIsDead = true;
			DeathSound.SetActive (true);
			StartCoroutine (ShowAd());
		}
		if (coll.gameObject.tag == "PenaltyBall") {
			StartCoroutine (RestartLevel());
			GetComponent<Renderer> ().enabled = false;
			DeathParticle.SetActive (true);
			PlayerParticle.SetActive (false);
			JumpButton.SetActive (false);
			Destroyer.SetActive (false);
			SpawnCollider.SetActive(false);
			PlayerIsDead = true;
			DeathSound.SetActive (true);
			StartCoroutine (ShowAd());

			
		}
		if (coll.gameObject.tag == "FallDeathCollider") {
			StartCoroutine (RestartLevel());
			GetComponent<Renderer> ().enabled = false;
			DeathParticle.SetActive (true);
			PlayerParticle.SetActive (false);
			JumpButton.SetActive (false);
			Destroyer.SetActive (false);
			SpawnCollider.SetActive(false);
			PlayerIsDead = true;
			DeathSound.SetActive (true);
			StartCoroutine (ShowAd());
			
		}


}

	IEnumerator RestartLevel(){
		yield return new WaitForSeconds (0.6f);
		RestartButton.SetActive (true);

	}

	IEnumerator ShowAd(){
		yield return new WaitForSeconds (0.8f);
		Time.timeScale = 0;
		RandomNumber = Random.Range(0,3);
		Debug.Log ("" + RandomNumber);
		if (RandomNumber == 0 && Score.LearningPhase == false) {
			Debug.Log("pokaji ad");
			_AdmobManager.ShowInterstitial();
		}

	}
}
