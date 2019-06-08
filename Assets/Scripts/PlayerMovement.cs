using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public Rigidbody2D RB;
	private Vector2 moveVelocity;

	void Start (){
		RB = GetComponent<Rigidbody2D> ();
	}

	void Update (){
		Vector2 moveInput = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput.normalized * speed;
	}
	void FixedUpdate(){
		RB.MovePosition (RB.position + moveVelocity * Time.fixedDeltaTime);
	}
}
