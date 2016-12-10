using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag == "Player") {
			Score.score += 1f;
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
	}
}
