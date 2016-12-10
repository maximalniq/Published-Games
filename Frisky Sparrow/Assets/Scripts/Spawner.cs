using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	int numObsticles = 5;

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Obsticle") {
			Vector3 pos = collider.transform.position;
			pos.y += 48;
			collider.transform.position = pos;
		}
		if (collider.tag == "Penalty") {
			Vector3 pos = collider.transform.position;
			pos.y += 48;
			collider.transform.position = pos;
		}
	}

}
