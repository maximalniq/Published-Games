using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {
	public float BallRotationSpeed = 1.5f;
	void Update () {
		transform.Rotate (Vector3.forward * BallRotationSpeed);
	}
}
