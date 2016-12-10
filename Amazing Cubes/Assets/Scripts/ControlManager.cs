using UnityEngine;
using System.Collections;

public class ControlManager : MonoBehaviour {

	public Transform Target;
	public Transform MainTarget;
	public Transform RTarget;
	public Transform RLTarget;
	public float speed;
	public bool LeftButtonHeldDown = false;
	public bool RightButtonHeldDown = false;



	public void OnLeftButtonHeldDown() {
	LeftButtonHeldDown = true;
	}

	public void OnLeftButtonHeldUp(){
		LeftButtonHeldDown = false;
	}

	public void OnRightButtonHeldDown(){
		RightButtonHeldDown = true;
	}

	public void OnRightButtonHeldUp(){
		RightButtonHeldDown = false;
	}

	void Update () {

		if (LeftButtonHeldDown == true) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, Target.position, step);
			} 

		if (LeftButtonHeldDown == false && RightButtonHeldDown == false) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, MainTarget.position, step);
		}

		if (RightButtonHeldDown == true) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, RTarget.position, step);
		}

		if (LeftButtonHeldDown == true && RightButtonHeldDown == true) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, RLTarget.position, step);

		}
	}
}
