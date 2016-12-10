using UnityEngine;
using System.Collections;

public class DeathParticle : MonoBehaviour {
	public GameObject PDeathLCube;
	public GameObject PDeathRCube;
	public static bool DeathParticles = false;

	void Start (){
		DeathParticles = false;
	}

	void Update () {

		if (DeathParticles == false) {
			PDeathLCube.SetActive (false);
			PDeathRCube.SetActive (false);
		}

		if (DeathParticles == true) {
			PDeathLCube.SetActive (true);
			PDeathRCube.SetActive (true);
		}
	}
	


}
