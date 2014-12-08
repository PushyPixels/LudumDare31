using UnityEngine;
using System.Collections;

public class SpawnRandomly : MonoBehaviour
{
	public GameObject[] objectsToSpawn;
	public float spawnRadius = 10.0f;
	public float minSpawnDelay = 1.0f;
	public float maxSpawnDelay = 2.0f;

	// Use this for initialization
	void Start ()
	{
		Invoke("Spawn",Random.Range(minSpawnDelay,maxSpawnDelay));
	}

	void Spawn ()
	{
		Instantiate(objectsToSpawn[Random.Range(0,objectsToSpawn.Length)],transform.position + (Vector3)Random.insideUnitCircle*spawnRadius, Quaternion.LookRotation(Random.insideUnitCircle));
		Invoke("Spawn",Random.Range(minSpawnDelay,maxSpawnDelay));
	}
}
