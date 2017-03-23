using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LightIntensitySliderScript : MonoBehaviour {

	public Light mainLight;
	Slider lightSlider;
	float initIntensity;
	// Use this for initialization
	void Start () {
		lightSlider = GetComponent<Slider> ();
		initIntensity = mainLight.intensity;
	}
	
	// Update is called once per frame
	public void changeValue () {
		mainLight.intensity = initIntensity * lightSlider.value;
	}
}
