using UnityEngine;
using System.Collections;

public class ScoreSound : MonoBehaviour {
	public static bool ActivateSound = false;

	void Update (){
		if (ActivateSound == true) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			ActivateSound = false;
		}
	}
}
