using UnityEngine;
using System.Collections;

public class Spawn: MonoBehaviour {

	//public int numObjects = 1 ;
	public int r = 60;
	public GameObject prefab;
	public float spawnRate = 0f;
	private float nextSpawn = 0f;


	void Start() {
		
	}

	void Update(){

		spawnRate = Random.Range(4, 8);

		if (Time.time > nextSpawn) {
			Debug.Log (spawnRate);

			nextSpawn = Time.time + spawnRate;

			Vector3 center = transform.position;

			Vector3 pos = RandomCircle(center, 100f);
			Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center-pos);
			Instantiate(prefab, pos, rot);
		}
	}

	Vector3 RandomCircle (Vector3 center, float radius){
		Vector3 pos;
		Vector2 pos2d = Random.insideUnitCircle.normalized * r;

		pos.x = pos2d.x;
		pos.z = pos2d.y;
		pos.y = Random.Range (-50, 50);

		return pos;
	}
}