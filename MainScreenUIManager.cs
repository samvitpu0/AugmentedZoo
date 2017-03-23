using UnityEngine;
using System.Collections;

public class MainScreenUIManager : MonoBehaviour {

	bool toggle=true;
	bool lightSliderToggle=true;

	public void onBack(Animator back)
	{
		if (toggle) {
			back.SetBool ("SlideIn", true);
		    
		} else {
			back.SetBool ("SlideIn", false);

		}
	}

	public void onHide(Animator hide)
	{
		if (toggle) {
			hide.SetBool ("SlideIn", true);

		} else {
			hide.SetBool ("SlideIn", false);

		}
	}

	public void onInfo(Animator info)
	{
		if (toggle) {
			info.SetBool ("SlideIn", true);

		} else {
			info.SetBool ("SlideIn", false);

		}
	}



	public void onMore(Animator more)
	{
		if (toggle) {
			more.SetBool ("Rotate", true);
			toggle = false;
		} else {
			more.SetBool ("Rotate", false);
			toggle = true;
		}
	}

	public void onLightSlider(Animator slider)
	{
		if (lightSliderToggle) {
			slider.SetBool ("slideIn", true);
			lightSliderToggle = false;
		} else {
			slider.SetBool ("slideIn", false);
			lightSliderToggle = true;
		}
	}

}
