using UnityEngine;
using System.Collections;

public class EnableBehavioursOnGameStart : MonoBehaviour
{
	public Behaviour[] behavioursToEnable;
	
	void OnEnable ()
	{
		GameManager.OnGameStart += OnGameStart;
	}

	void OnDisable ()
	{
		GameManager.OnGameStart -= OnGameStart;
	}

	void OnGameStart()
	{
		foreach(Behaviour bev in behavioursToEnable)
		{
			bev.enabled = true;
		}
	}
}
