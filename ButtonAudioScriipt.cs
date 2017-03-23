using UnityEngine;
using System.Collections;

public class ButtonAudioScriipt : MonoBehaviour {

	public AudioSource buttonClick;

	public void onButtonClick()
	{
		buttonClick.Play ();
	}
}
