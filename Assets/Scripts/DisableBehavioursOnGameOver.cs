﻿using UnityEngine;
using System.Collections;

public class DisableBehavioursOnGameOver : MonoBehaviour
{
	public Behaviour[] behavioursToDisable;
	
	void OnEnable ()
	{
		GameManager.OnGameOver += OnGameOver;
	}

	void OnDisable ()
	{
		GameManager.OnGameOver -= OnGameOver;
	}

	void OnGameOver()
	{
		foreach(Behaviour bev in behavioursToDisable)
		{
			bev.enabled = false;
		}
	}
}
