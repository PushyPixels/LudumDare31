using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
	public float distanceFromCamera = 10.0f;
	
	// Update is called once per frame
	void Update ()
	{
		Rect screenRect = new Rect(0,0, Screen.width, Screen.height);
		if (!screenRect.Contains(Input.mousePosition))
		{
			return;
		}
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward*distanceFromCamera);
	}
}
