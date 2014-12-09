using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

	public GameObject gameOverDisplay;
	public GameObject instructions;
	public GameObject playerPrefab;
	public GameObject mainSpawner;

	public static int score;
	public static int highScore;
	public static int multiplier;
	public float scorePerSecond = 1.0f;

	private bool started = false;
	private bool gameOver = false;

	private float t;

	public delegate void GameManagerEvent();
	public static event GameManagerEvent OnGameOver;
	public static event GameManagerEvent OnGameStart;
	
	void Awake()
	{
		Instance = this;
		score = 0;
		multiplier = 1;
		highScore = PlayerPrefs.GetInt("HighScore",0);
	}

	void Update()
	{
		Screen.showCursor = false;

		if(started)
		{
			if(!gameOver)
			{
				t += Time.deltaTime;

				while(t > scorePerSecond)
				{
					t -= scorePerSecond;
					score += multiplier;
				}

				if(score > highScore)
				{
					highScore = score;
				}
			}
			else
			{
				if(Input.anyKeyDown)
				{
					Application.LoadLevel(Application.loadedLevel);
				}
			}
		}
		else
		{
			if(Input.anyKeyDown)
			{
				StartGame();
			}
		}
	}

	void StartGame()
	{
		started = true;
		Instantiate(playerPrefab);
		instructions.SetActive(false);
		mainSpawner.SetActive(true);
		OnGameStart.Invoke();
	}

	public static void GameOver()
	{
		if(Instance.gameOver == false)
		{
			Instance.gameOver = true;
			Instance.gameOverDisplay.SetActive(true);
			PlayerPrefs.SetInt("HighScore",highScore);
			PlayerPrefs.Save();
			if(OnGameOver != null)
			{
				OnGameOver.Invoke();
			}
		}
	}
}
