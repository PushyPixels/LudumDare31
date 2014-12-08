using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public GameObject bullet;
	public float delay = 1.0f;

	// Use this for initialization
	void Start ()
	{
		Invoke ("ActuallyShoot",delay);
	}

	void ActuallyShoot ()
	{
		Instantiate(bullet,transform.position,transform.rotation);
		Invoke ("ActuallyShoot",delay);
	}
}
