﻿using UnityEngine;
using System.Collections;

public class PlayerSpeed : MonoBehaviour {

	public float verticalspeed;
	// Update is called once per frame

	void Update () {
		
		transform.position += -transform.up * verticalspeed * Time.deltaTime ;
		if (verticalspeed <= 12) {
			verticalspeed += Time.deltaTime /10;
		}

	}
}
