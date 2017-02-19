using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveScript : MonoBehaviour {
	// Update is called once per frame
	public Rigidbody duck;
	void Update () {
		if (Random.value > .5) {
			duck.velocity = new Vector3(100 * Random.value, duck.velocity.y, duck.velocity.z);
		}
		else {
			duck.velocity = new Vector3(-100 * Random.value, duck.velocity.y, duck.velocity.z);
		}
		if (Random.value > .5) {
			duck.velocity = new Vector3 (duck.velocity.x, duck.velocity.y, 100 * Random.value);
		}
		else {
			duck.velocity = new Vector3 (duck.velocity.x, duck.velocity.y, -100 * Random.value);
		}
	}
}
