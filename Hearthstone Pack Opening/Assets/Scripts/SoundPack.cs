using UnityEngine;
using System.Collections;

public class SoundPack : MonoBehaviour {

	public void OnClassicPackClicked(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
}
