﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftBoundaryTrigger : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Ball")
		{
			Destroy(other.gameObject);
			Ball.numberOfBalls -= 1;
			GameControl.instance.incrementLeftPlayerScore();
			Debug.Log(other.tag);
			if (Ball.numberOfBalls == 0)
			{
				GameControl.instance.gameOver();
				// SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
		}

	}
}
