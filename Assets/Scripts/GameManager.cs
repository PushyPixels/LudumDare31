using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

	public GameObject gameOverDisplay;

	public static int score;
	public float scorePerSecond = 1.0f;

	private bool gameOver = false;
	private int multiplier = 1;

	private float t;

	public delegate void GameManagerEvent();
	public static event GameManagerEvent OnGameOver;
	
	void Awake()
	{
		Instance = this;
		score = 0;
	}

	void Update()
	{
		if(!gameOver)
		{
			t += Time.deltaTime;

			while(t > scorePerSecond)
			{
				t -= scorePerSecond;
			}
			Debug.Log(score);
		}
	}

	public static void IncreaseMultiplier()
	{
		Instance.multiplier++;
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
