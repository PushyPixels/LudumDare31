using UnityEngine;
using System.Collections;

public class TestTrigger : MonoBehaviour
{
	public string testString = "We triggered!";

	void OnTriggerEnter()
	{
		Debug.Log(testString);
	}
}
