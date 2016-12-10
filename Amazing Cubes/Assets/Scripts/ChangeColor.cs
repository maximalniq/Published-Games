using UnityEngine;
using System.Collections;

public class ChangeColor: MonoBehaviour {
	public static bool ChangeColourBool = false;
	public static int RandomColour;


	public  void Start (){
		if (RandomColour == 0 && ChangeColourBool == true) {
			Color rc = new Color (1,0,0);
			GetComponent<Renderer> ().material.color = rc;
			Debug.Log("oranjevo");
		}
		if (RandomColour == 1 && ChangeColourBool == true) {
			Color rc = new Color (1,0,1);
			GetComponent<Renderer> ().material.color = rc;
			Debug.Log("lilavo");
		}
		if (RandomColour == 2 && ChangeColourBool == true) {
			Color rc = new Color (1,1,0);
			GetComponent<Renderer> ().material.color = rc;
			Debug.Log("jalto zeleno");
		}
		if (RandomColour == 3 && ChangeColourBool == true) {
			Color rc = new Color (0,1,1);
			GetComponent<Renderer> ().material.color = rc;
			Debug.Log("sinio");
		}
		if (RandomColour == 4 && ChangeColourBool == true) {
			Color rc = new Color (0,1,0);
			GetComponent<Renderer> ().material.color = rc;
			Debug.Log("zeleno");
		}
	

		}
}
