using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	public void OnJumpButtonClicked (){
			rb.velocity = new Vector3 (0, 5, 0);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
}
}