﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 50f;

	private Rigidbody2D rigidBody;
	private Animator animator;

	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
//		animator.SetFloat ("Player_Velocity_Horiz", Mathf.Abs(Input.GetAxis("
		animator.SetFloat ("Player_Velocity_Horiz", Mathf.Abs(rigidBody.velocity.x));
	}

	void FixedUpdate() {
		float horizForce = Input.GetAxis("Horizontal");
		rigidBody.AddForce (Vector2.right * speed * horizForce);
	}
}
