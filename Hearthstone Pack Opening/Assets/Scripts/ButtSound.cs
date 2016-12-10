using UnityEngine;
using System.Collections;

public class ButtSound : MonoBehaviour {

	public void PlayButtonSound (){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
}
