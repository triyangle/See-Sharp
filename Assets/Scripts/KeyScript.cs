using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour {

	private AudioSource a;
	public string letter;
	public float timer = 0.0f;
	public float pressDownTime = 0.2f;
	public float startPos;
	// Use this for initialization
	void Start () {
		a = GetComponent<AudioSource>();
		startPos = transform.position.y;
	}

	void Update () {
		if (Input.GetKeyDown(letter)) {
			timer = pressDownTime;
			a.Play ();
		}

		if (timer > 0) {
			timer -= Time.deltaTime;
		}
		if (timer < 0) {
			timer = 0;
		}
		transform.position = new Vector3(transform.position.x, 
							 Mathf.Lerp(startPos, startPos + 0.20f, (pressDownTime - timer) / pressDownTime), 
							 transform.position.z); 
	
	}
}