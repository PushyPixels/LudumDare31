using UnityEngine;
using System.Collections;

public class DisableBehavioursOnGameOver : MonoBehaviour
{
	public Behaviour[] behavioursToDisable;

	// Use this for initialization
	void OnEnable ()
	{
		GameManager.OnGameOver += OnGameOver;
	}
	
	// Update is called once per frame
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
