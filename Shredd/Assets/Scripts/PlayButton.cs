using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	public void OnButtonPressed (){
		Time.timeScale = 1;
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("StartMenu");
		foreach (GameObject target in gameObjects) {
			GameObject.Destroy (target);

		}


		






	}
}
