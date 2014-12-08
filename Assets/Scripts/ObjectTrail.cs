using UnityEngine;
using System.Collections;

public class ObjectTrail : MonoBehaviour
{
	public GameObject trailObject;
	public float newObjectDistance = 1.0f;
	public float sizeRatio = 1.0f;
	
	private Vector3 currentObjectStartPosition;
	private GameObject currentObject;

	// Update is called once per frame
	void LateUpdate ()
	{
		if(currentObject == null)
		{
			currentObject = Instantiate(trailObject,transform.position,Quaternion.identity) as GameObject;
			currentObjectStartPosition = transform.position;
		}
		else
		{
			Vector3 toTransformVector = transform.position - currentObjectStartPosition;

			float distance = toTransformVector.magnitude;

			if(distance > 0.0f)
			{
				currentObject.transform.rotation = Quaternion.LookRotation(toTransformVector);
			}

			Vector3 newScale = currentObject.transform.localScale;
			newScale.z = distance*sizeRatio;
			currentObject.transform.localScale = newScale;


			if(distance >= newObjectDistance)
			{
				currentObject = Instantiate(trailObject,transform.position,Quaternion.identity) as GameObject;
				currentObjectStartPosition = transform.position;
			}
		}
	}
}
