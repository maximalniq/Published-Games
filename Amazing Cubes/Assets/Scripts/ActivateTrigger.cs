using UnityEngine;
using System.Collections;

public class ActivateTrigger : MonoBehaviour {

	public static bool SpawnNow = false;
	public static int randomnumber;
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Obsticle") {
			SpawnNow = true;
			randomnumber = Random.Range (-1, 3);
			Debug.Log (randomnumber);
		}
	}
}
