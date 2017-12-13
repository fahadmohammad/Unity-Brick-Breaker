using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public UI ui;
	
	// Use this for initialization
	void Start()
	{
		ui = GameObject.FindWithTag("ui").GetComponent<UI>();
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "ball")
		{
			ui.IncrementScore();
			Destroy(gameObject);
 
		}
	}
}
