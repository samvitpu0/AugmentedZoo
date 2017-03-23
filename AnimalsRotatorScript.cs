using UnityEngine;
using System.Collections;

public class AnimalsRotatorScript : MonoBehaviour {

	public float rotationSpeed;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 1) 
		{
			float touchValue = Input.GetTouch (0).deltaPosition.x;
			transform.Rotate (-1f * Vector3.up * touchValue * rotationSpeed * Time.deltaTime, Space.World);
		}

	}
}
