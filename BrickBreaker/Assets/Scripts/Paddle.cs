﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	[SerializeField] private float maxX;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");

		if (x == 0)
		{
			Stop();
		}
		if (x < 0)
		{
			MoveLeft();
		}
		if (x > 0)
		{
			MoveRight();
		}
		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
		transform.position = pos;

		
	}
	void MoveLeft()
	{
		rb.velocity = new Vector2(-speed, 0);
	}
	void MoveRight()
	{
		rb.velocity = new Vector2(speed, 0);
	}
	void Stop()
	{
		rb.velocity = Vector2.zero;

	}
}
