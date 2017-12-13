using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public UI ui;
	public Rigidbody2D rb;
	public float ballForce;
	bool gameStarted = false;
	//bool check = true;
	
	
	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag("ui").GetComponent<UI>();
	}
	
	// Update is called once per frame
	

	void Update () {
		if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
		{
			transform.SetParent(null);
			rb.isKinematic = false;
			
			rb.AddForce(new Vector2(ballForce, ballForce));

			gameStarted = true;
			
		}
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.tag == "quad")
		{
			ui.DecrementScore();

		}
	}
	
}
