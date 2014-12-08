using UnityEngine;
using System.Collections;

public class IncreaseMultiplierOnTrigger : MonoBehaviour
{
	void OnTriggerEnter()
	{
		GameManager.multiplier++;
		Destroy(gameObject);
	}
}
