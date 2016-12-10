using UnityEngine;
using System.Collections;

public class PeanltyBallSpeed : MonoBehaviour {
	
	// Update is called once per frame
	
	void Update () {
		
		transform.position += transform.right * 6 * Time.deltaTime ;

}
	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "Destroyer") {
			Destroy(gameObject);
		}
	}
}
