using UnityEngine;
using System.Collections;

public class GibOnGameOver : MonoBehaviour
{
	public GameObject gib;
	
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
		Instantiate(gib,transform.position,transform.rotation);
		Destroy (gameObject);
	}
}
