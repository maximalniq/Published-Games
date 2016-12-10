using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag == "Player") {
			Debug.Log ("Bachka");
			Score.score += 0.5f;
			ScoreSound.ActivateSound = true;
		}
	}
}
