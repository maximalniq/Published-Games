using UnityEngine;
using System.Collections;

public class HidePlayer : MonoBehaviour {

	public static bool hideplayer = false;
	void Start () {
		hideplayer = false;
	}

	void Update () {

		if (hideplayer == true) {
			GetComponent<Renderer> ().enabled = true;
		}

		if (hideplayer == true) {
			GetComponent<Renderer> ().enabled = false;
		}
	}
}
