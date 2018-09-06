using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject[] enemies; //Array, mehrere GameObjects
	public Vector3 spawnValues; //fuer Grenzen, Zeiten
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;

	int randEnemy; //random objekt

	void Start () {

		StartCoroutine(waitSpawner());		
	}
	
	
	void Update () {

		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
		
	}

	IEnumerator waitSpawner () {
		yield return new WaitForSeconds (startWait); //ab wann es spawnt
		
		while (!stop) {
			randEnemy = Random.Range (0, 2); //welches
		
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z)); //wo

			Instantiate (enemies[randEnemy], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

			//Wartezeit bis zum naechsten Spawn
			yield return new WaitForSeconds (spawnWait); 
		}
	}
}
