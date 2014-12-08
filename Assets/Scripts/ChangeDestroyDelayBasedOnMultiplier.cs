using UnityEngine;
using System.Collections;

public class ChangeDestroyDelayBasedOnMultiplier : MonoBehaviour
{
	public float delayTimePerMultiplier = 0.1f;

	private DestroyAfterDelay destroyer;

	// Use this for initialization
	void Start ()
	{
		destroyer = GetComponent<DestroyAfterDelay>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		destroyer.delay = delayTimePerMultiplier*GameManager.multiplier;
	}
}
