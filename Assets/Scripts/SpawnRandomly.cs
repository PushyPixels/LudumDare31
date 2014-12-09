using UnityEngine;
using System.Collections;

public class SpawnRandomly : MonoBehaviour
{
	public GameObject[] objectsToSpawn;
	public float spawnRadius = 10.0f;
	public float minSpawnDelay = 1.0f;
	public float maxSpawnDelay = 2.0f;
	public bool validateSpawnPosition;
	public float validRadius = 1.0f;
	public LayerMask invalidateLayers = -1;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(Spawn());
	}

	IEnumerator Spawn ()
	{
		yield return new WaitForSeconds(Random.Range(minSpawnDelay,maxSpawnDelay));

		Vector3 position = transform.position + (Vector3)Random.insideUnitCircle*spawnRadius;

		if(validateSpawnPosition)
		{
			while(Physics.CheckSphere(position,validRadius,invalidateLayers))
			{
				position = transform.position + (Vector3)Random.insideUnitCircle*spawnRadius;
				yield return null;
			}
		}

		Instantiate(objectsToSpawn[Random.Range(0,objectsToSpawn.Length)], position, Quaternion.LookRotation(Random.insideUnitCircle));
		StartCoroutine(Spawn());
	}
}
