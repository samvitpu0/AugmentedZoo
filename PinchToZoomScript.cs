using UnityEngine;
using System.Collections;

public class PinchToZoomScript : MonoBehaviour {

	public float scaleFactor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 2) {
			Touch touchZero = Input.GetTouch (0);
			Touch touchOne = Input.GetTouch (1);

			// Find the position in the previous frame of each touch.
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			// Find the magnitude of the vector (the distance) between the touches in each frame.
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			// Find the difference in the distances between each frame.
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			transform.localScale = new Vector3 (-1*deltaMagnitudeDiff*scaleFactor*transform.localScale.x,-1*deltaMagnitudeDiff*scaleFactor*transform.localScale.y,-1*deltaMagnitudeDiff*scaleFactor*transform.localScale.z);
			Debug.Log (deltaMagnitudeDiff);
		}

	}
}
