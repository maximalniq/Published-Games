using UnityEngine;
using System.Collections;

public class RotateObsticle : MonoBehaviour {
	public float RotationSpeed;
	public bool RotateRight;
	public int RandomNumber;
	void Start (){
		RandomNumber = Random.Range (0, 2);
	}
	void Update () {
		if (RandomNumber == 0) {
			RotateRight = true;
		}
		if (RandomNumber == 1) {
			RotateRight = false;
		}
		if (RotateRight == true) {
			transform.Rotate (Vector3.back * RotationSpeed);
		}
		if (RotateRight == false) {
			transform.Rotate (Vector3.forward * RotationSpeed);
		}
	}
}
