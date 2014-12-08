using UnityEngine;
using System.Collections;

public class ChangeTrailTimeBasedOnMultiplier : MonoBehaviour
{
	public float trailTimePerMultiplier = 0.1f;

	private TrailRenderer trail;

	// Use this for initialization
	void Start ()
	{
		trail = GetComponent<TrailRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		trail.time = trailTimePerMultiplier*GameManager.multiplier;
	}
}
