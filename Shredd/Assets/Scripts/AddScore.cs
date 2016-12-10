using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {

	void OnTriggerEnter (Collider collider) {
		if (collider.tag == "Player") {
			Score.score += 0.5f;
		}
	}
}
