using UnityEngine;
using System.Collections;

public class GameOverOnTrigger : MonoBehaviour {

	void OnTriggerEnter()
	{
		GameManager.GameOver();
	}
}
