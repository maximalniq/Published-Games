using UnityEngine;
using System.Collections;

public class RespawnScript : MonoBehaviour {

	void OnTriggerEnter (Collider collider) {
		if (collider.tag == "RespawnCollider"){
			Debug.Log ("Enter");
			transform.position = new Vector3(0,45,0);
		}
	}
}
