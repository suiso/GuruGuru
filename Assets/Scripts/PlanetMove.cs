using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanetMove : MonoBehaviour {

	float rotateAngle;
	int rotateSpeed;

	void Start () {
	rotateAngle = 0.0f;
	rotateSpeed = 20;
	}

	void Update () {
	rotateAngle += Time.deltaTime * rotateSpeed;
	transform.rotation = Quaternion.Euler(0,0,rotateAngle);
	}
}
