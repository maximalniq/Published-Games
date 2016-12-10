using UnityEngine;
using System.Collections;

public class PenaltyBallSpawner : MonoBehaviour {
	public GameObject PenaltyBall;
	public bool PenaltyBallActive;
	public double SpawnTimer = 0;

	public void SpawnPenaltyBall (){
		Instantiate(PenaltyBall, transform.position, Quaternion.identity);
	}
	void Update (){
		SpawnTimer += Time.deltaTime;

		if (SpawnTimer > 3) {
			PenaltyBallActive = true;
		}
		if (PenaltyBallActive == true) {
			SpawnPenaltyBall ();
			PenaltyBallActive = false;
			SpawnTimer = 0;
		}
	}

}
