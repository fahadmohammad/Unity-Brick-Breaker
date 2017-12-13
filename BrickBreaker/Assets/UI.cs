using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text scoreText;
	public Text lifeText;
	public Text gameOver;
	int score = 0;
	int life = 3;
	// Use this for initialization
	void Start () {
		gameOver.text = " ";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void IncrementScore()
	{
		score++;
		scoreText.text = "Score: " + score; 
	}
	public void DecrementScore()
	{
		life--;
		if (life > 0)
		{
			lifeText.text = "Life: " + life; 
		}
		else if(life == 0)
		{
			Destroy(GameObject.FindWithTag("ball"));
			lifeText.text = "Life: " + life; 
			gameOver.text = "Game Over!!";
		}
		
	}
}
