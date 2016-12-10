using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject LeftRiightObsticle;
	public GameObject Obsticle;


	void spawnCenter() {
		Instantiate(Obsticle, new Vector3(0, -40, 0), Quaternion.identity);
		}
	
	void spawnLeft() {
		Instantiate(Obsticle, new Vector3(-1, -40, 0), Quaternion.identity);
	}
	
	void spawnRight() {
		Instantiate(Obsticle, new Vector3(1, -40, 0), Quaternion.identity);
	}
	void spawnLeftRight() {
		Instantiate(LeftRiightObsticle, new Vector3(0, -40, 0), Quaternion.identity);
	}


	void Update (){
		if (ActivateTrigger.randomnumber == -1 && ActivateTrigger.SpawnNow == true) {
			ActivateTrigger.SpawnNow = false;
			spawnLeft();
			}
		if (ActivateTrigger.randomnumber == 1 && ActivateTrigger.SpawnNow == true) {
			ActivateTrigger.SpawnNow = false;
			spawnCenter();
		}
		if (ActivateTrigger.randomnumber == 0 && ActivateTrigger.SpawnNow == true) {
			ActivateTrigger.SpawnNow = false;
			spawnRight();
		}
		if (ActivateTrigger.randomnumber == 2 && ActivateTrigger.SpawnNow == true) {
			ActivateTrigger.SpawnNow = false;
			spawnLeftRight();
		}
			}

		}
