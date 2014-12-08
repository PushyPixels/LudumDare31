using UnityEngine;
using System.Collections;

public class DestroyAfterDelay : MonoBehaviour
{
	public float delay = 1.0f;

	private float t = 0.0f;

	void Update()
	{
		t += Time.deltaTime;
		if(t > delay)
		{
			Destroy(gameObject);
		}
	}
}
