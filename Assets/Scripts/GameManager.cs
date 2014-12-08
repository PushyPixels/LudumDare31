using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

	public GameObject gameOverDisplay;

	private bool gameOver = false;
	
	void Awake()
	{
		Instance = this;
	}

	public static void GameOver()
	{
		if(Instance.gameOver == false)
		{
			Instance.gameOver = true;
			Instance.gameOverDisplay.SetActive(true);
		}
	}
}
