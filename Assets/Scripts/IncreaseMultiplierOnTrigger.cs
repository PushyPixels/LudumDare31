using UnityEngine;
using System.Collections;

public class IncreaseMultiplierOnTrigger : MonoBehaviour
{
	private bool hasTriggered = false;

	void OnTriggerEnter()
	{
		if(!hasTriggered)
		{
			GameManager.multiplier++;
			hasTriggered = true;
			Destroy(gameObject);
		}
	}
}
