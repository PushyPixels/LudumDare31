using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

	public GameObject gameOverDisplay;

	public static int score;
	public static int multiplier;
	public float scorePerSecond = 1.0f;

	private bool gameOver = false;

	private float t;

	public delegate void GameManagerEvent();
	public static event GameManagerEvent OnGameOver;
	
	void Awake()
	{
		Instance = this;
		score = 0;
		multiplier = 1;
	}

	void Update()
	{
		Screen.showCursor = false;
		if(!gameOver)
		{
			t += Time.deltaTime;

			while(t > scorePerSecond)
			{
				t -= scorePerSecond;
				score += multiplier;
			}
		}
	}

	public static void GameOver()
	{
		if(Instance.gameOver == false)
		{
			Instance.gameOver = true;
			Instance.gameOverDisplay.SetActive(true);
			if(OnGameOver != null)
			{
				OnGameOver.Invoke();
			}
		}
	}
}
