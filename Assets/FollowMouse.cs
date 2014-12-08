using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
	public float distanceFromCamera = 10.0f;
	
	// Update is called once per frame
	void LateUpdate ()
	{
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward*distanceFromCamera);
	}
}
