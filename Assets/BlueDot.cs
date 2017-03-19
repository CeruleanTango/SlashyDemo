﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDot : MonoBehaviour {

	public void Start() {
		LevelMaster.blueDotsRemaining++;
	}
		
	public void OnTriggerEnter2D(Collider2D collider) {
		LevelMaster.CollectBlueDot ();
		Destroy (this.gameObject);
	}
}
