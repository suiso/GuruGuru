using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 2f;
	public float radius = 3f;


	void Awake() {
	}

	void Update () {
		float x = Mathf.Cos(Time.time * speed) * radius;
		float y = Mathf.Sin(Time.time * speed) * radius;
		float z = 0f;
		transform.position = new Vector3(x, y, z);
	}

	void RadiusControll() {
		if (Input.GetKeyDown("left")) {
			radius -= 0.1f;
		}
		else if (Input.GetKeyDown("right")) {
			radius += 0.1f;
		}
	}
}
