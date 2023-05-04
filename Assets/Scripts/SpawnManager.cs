using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public GameObject[] animalPrefabs;
	private float spawnRangeX = 20;
	private float spawnRangeZ = 20;
	private float startDelay = 2;
	private float spawnInterval = 2.0f;

	void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
		InvokeRepeating("SpawnRandomAnimalLeft", startDelay + 2, spawnInterval);
		InvokeRepeating("SpawnRandomAnimalRight", startDelay + 4, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void SpawnRandomAnimal()
	{
		int animalIndex = Random.Range(0, 3);
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);



	}

	void SpawnRandomAnimalLeft()
	{
		int animalIndex = Random.Range(3, 6);
		Vector3 spawnPos = new Vector3(-24, 0, Random.Range(4, 14));

		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);



	}

	void SpawnRandomAnimalRight()
	{
		int animalIndex = Random.Range(6, animalPrefabs.Length);
		Vector3 spawnPos = new Vector3(24, 0, Random.Range(4, 14));

		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);



	}
}
