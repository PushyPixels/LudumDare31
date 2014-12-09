using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
	public static MusicManager Instance;
	
	void Awake ()
	{
		if(Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
