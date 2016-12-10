using UnityEngine;
using System.Collections;

public class DeathSound : MonoBehaviour {

	public static bool DeathSoundActive = false;

	void Update () {
		if (DeathSoundActive == true) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			DeathSoundActive = false;
		}
	}
}
