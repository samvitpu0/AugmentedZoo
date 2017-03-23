using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreenScript : MonoBehaviour {

	double endTime;
	// Use this for initialization
	void Start () {
		endTime = 3.0f + Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		double timeLeft = endTime - Time.time;
		if (timeLeft < 0)
			SceneManager.LoadScene (1);
	}
}
